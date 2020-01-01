using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KfzVerwaltung.Data;

namespace KfzVerwaltung
{
    public partial class FormMain : Form
    {
        #region fields
        private FileManager securedFile = null;
        private string masterPassword = string.Empty;
        private string userPath = string.Empty;
        #endregion

        #region contructors
        public FormMain()
        {
            InitializeComponent();
            GetPropertiesSettings();
        }
        #endregion

        #region methods
        private void menuItemFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Kfz XML Datei|*.xml";
            if (Properties.Settings.Default.LastFilePath != string.Empty) dialog.InitialDirectory = Properties.Settings.Default.LastFilePath; // open last file path
            PositioningNavigationPanel(this.menuItemFileOpen);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName.ToLower().EndsWith(".xml"))
                {
                    FormLogin loginForm = new FormLogin();  // check user access
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        panelList.Controls.Clear();
                        try
                        {
                            this.securedFile = FileManager.Read(dialog.FileName, loginForm.Password);
                            if (this.securedFile.Owner == loginForm.Username)
                            {
                                this.masterPassword = loginForm.Password;
                                foreach (Car car in this.securedFile.Cars) LoadUserControl(car);
                                this.pictureBoxAvatar.Visible = true;
                                this.statusLabelUser.Visible = true;
                                this.statusLabelUser.Text = loginForm.Username.ToString();
                                this.StatusLabelSave.Visible = true;
                                this.StatusLabelSave.Text = dialog.FileName.ToString();
                                this.statusLabelInformation.Text = dialog.FileName;
                            }
                            else
                            {
                                MessageBox.Show("Sie sind nicht berechtigt die Datei zu lesen!", "Berechtigung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.securedFile = null;
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sie sind nicht berechtigt die Datei zu lesen!", "Berechtigung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.securedFile = null;
                            return;
                        }
                    }
                }
                else
                {
                    if (!dialog.FileName.ToLower().EndsWith(".xml")) MessageBox.Show("Bitte wählen Sie eine .xml-Datei aus.", "Falsche Dateiauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void menuItemNewKfz_Click(object sender, EventArgs e)
        {
            PositioningNavigationPanel(this.menuItemNewKfz);
            if (panelList.Controls.Contains(pictureBoxHere)) panelList.Controls.Clear();                

            if (this.securedFile == null)
            {
                this.securedFile = new FileManager();
                this.securedFile.CreationDate = DateTime.Now;
            }

            FormKfz kfzForm = new FormKfz();
            if (kfzForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserControl(kfzForm.Car);
            }
        }
        private void menuItemFileSave_Click(object sender, EventArgs e)
        {
            PositioningNavigationPanel(this.menuItemFileSave);
            if (this.securedFile != null)
            {
                if (String.IsNullOrEmpty(this.masterPassword))
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Kfz Verwaltung XML Datei|*.xml";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FormLogin loginForm = new FormLogin();
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            Save(dialog.FileName, loginForm.Username, loginForm.Password, dialog.InitialDirectory);
                        }
                    }
                }
                else
                {
                    Save(this.statusLabelInformation.Text, string.Empty, this.masterPassword, this.statusLabelInformation.Text);
                }
            }
        }
        private void menuItemQuit_Click(object sender, EventArgs e)
        {
            PositioningNavigationPanel(this.menuItemQuit);
            Properties.Settings.Default.WindowLocation = this.Location; //save Usersettings
            Properties.Settings.Default.WindowSize = this.Size;
            Application.Exit();
        }
        private void LoadUserControl(Car car)
        {
            UserControl userControl = null;
            userControl = new UserControlKfz(car);

            // Styling & Positioning
            int ucTop = 0;
            if (this.panelList.Controls.Count > 0)
                ucTop = this.panelList.Controls[this.panelList.Controls.Count - 1].Location.Y + this.panelList.Controls[this.panelList.Controls.Count - 1].Size.Height;
            userControl.Location = new Point(5, ucTop + 5);
            userControl.Width = this.panelList.ClientRectangle.Width - 10;
            userControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userControl.BackColor = Color.FromArgb(180, 193, 204);

            this.panelList.Controls.Add(userControl);
        }
        private void GetPropertiesSettings()
        { 
            if (Properties.Settings.Default.WindowLocation != null)
            {
                if (Properties.Settings.Default.WindowLocation.X == 0 || Properties.Settings.Default.WindowLocation.Y == 0)
                {
                    // first start
                    // optional: add default values
                }
                else
                {
                    this.Location = Properties.Settings.Default.WindowLocation;
                }
            }
            if (Properties.Settings.Default.WindowSize != null) this.Size = Properties.Settings.Default.WindowSize;
        }
        private void SetPropertiesSettings(string LastFilePath)
        {
            Properties.Settings.Default.LastFilePath = LastFilePath; 
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.Save();
        }
        private void Save(string fileName, string userName, string password, string LastFilePath)
        {
            this.securedFile.Cars.Clear();
            foreach (UserControl userControl in this.panelList.Controls)
            {
                if (userControl is UserControlKfz)
                {
                    UserControlKfz ucKfz = (UserControlKfz)userControl;
                    this.securedFile.Cars.Add(ucKfz.Car);
                }
            }

            this.securedFile.LastUpdate = DateTime.Now;
            if (!String.IsNullOrEmpty(userName)) this.securedFile.Owner = userName;
            this.securedFile.Save(fileName, password);
            StatusLabelSave.Visible = true;
            StatusLabelSave.Text = "Speichern erfolgreich durchgeführt.";
            pictureBoxAvatar.Visible = true;
            statusLabelUser.Visible = true;
            statusLabelUser.Text = this.securedFile.Owner;
            

            this.timerSave.Enabled = true;  // timer for fade out
            SetPropertiesSettings(LastFilePath); // save new Usersettings
        }
        private void t1_Tick(object sender, EventArgs e)
        {
            Color myForeColor = this.StatusLabelSave.ForeColor;

            for (int i = 255; i >= 0; i--)
            {
                this.StatusLabelSave.ForeColor = Color.FromArgb(i, myForeColor);
                Thread.Sleep(20);
            }
            StatusLabelSave.Text = Properties.Settings.Default.LastFilePath;
            this.timerSave.Enabled = false;
        }
        private void PositioningNavigationPanel(Button btn)
        {
            pictureBoxNavigation.Top = btn.Top;
            pictureBoxNavigation.Visible = true;
        }
        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
        #endregion
    }
}