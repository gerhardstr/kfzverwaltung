using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KfzVerwaltung.Data;

namespace KfzVerwaltung
{
    public partial class FormMain : Form
    {
        private SecuredFile securedFile = null;
        private string masterPassword = string.Empty;
        private string userPath = string.Empty;

        public FormMain()
        {
            InitializeComponent(); 
        }

        public void GetSettings()
        {
            this.Location = Properties.Settings.Default.WindowLocation;
            this.Size = Properties.Settings.Default.WindowSize;
        }
        private void menuItemFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Kfz XML Datei|*.xml";

            if (Properties.Settings.Default.LastFilePath != string.Empty) dialog.InitialDirectory = Properties.Settings.Default.LastFilePath; // open last file path

            if (dialog.ShowDialog() == DialogResult.OK)
            {             
                FormLogin loginForm = new FormLogin();  // check user access
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        panelList.Controls.Clear(); 
                        this.securedFile = SecuredFile.Read(dialog.FileName, loginForm.Password);
                        if (dialog.FileName.ToLower().EndsWith(".xml"))
                            try
                            {
                                if (this.securedFile.Owner == loginForm.Username)
                                {
                                    this.masterPassword = loginForm.Password;
                                    foreach (Cars cars in this.securedFile.Cars) LoadUserControl(cars); 
                                    this.statusLabelInfo.Text = "Benutzer: " + loginForm.Username.ToString() + " | Dateipfad: " + dialog.FileName.ToString(); // statusstrip is required
                                    this.statusStripUserInformation.Text = dialog.FileName; // required for menuItemFileSave_Click
                                }
                                else
                                {
                                    MessageBox.Show("Sie sind nicht berechtigt die Datei zu lesen!");
                                    this.securedFile = null;
                                    return;
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Bitte wählen Sie eine xml-Datei aus!");
                                this.securedFile = null;
                                return;
                            }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bitte wählen Sie eine xml-Datei aus!");
                        this.securedFile = null;
                    }
                }
            }
        }
        private void menuItemNewKfz_Click(object sender, EventArgs e)
        {
            if (this.securedFile == null)
            {
                this.securedFile = new SecuredFile();
                this.securedFile.CreationDate = DateTime.Now;
            }

            FormKfz kfzForm = new FormKfz();
            if (kfzForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserControl(kfzForm.Cars);
            }
        }
        private void LoadUserControl(Cars car)
        {
            UserControl userControl = null;
            userControl = new UserControlKfz(car);

            int ucTop = 0;
            if (this.panelList.Controls.Count > 0)
            // Mario Styling
            ucTop = this.panelList.Controls[this.panelList.Controls.Count - 1].Location.Y + this.panelList.Controls[this.panelList.Controls.Count - 1].Size.Height;
            userControl.Location = new Point(5, ucTop + 2);
            userControl.Width = this.panelList.ClientRectangle.Width - 30;
            userControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            if (this.panelList.Controls.Count % 2 == 0) userControl.BackColor = Color.DarkGray;
            else userControl.BackColor = Color.LightGray;

            this.panelList.Controls.Add(userControl);
        }
        private void menuItemFileSave_Click(object sender, EventArgs e)
        {
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
                    Save(this.statusStripUserInformation.Text, string.Empty, this.masterPassword, this.statusStripUserInformation.Text);
                }
            }
        }
        private void Save(string fileName, string userName, string password, string LastFilePath)
        {
            this.securedFile.Cars.Clear();
            foreach (UserControl userControl in this.panelList.Controls)
            {
                if (userControl is UserControlKfz)
                {
                    UserControlKfz ucKfz = (UserControlKfz)userControl;
                    this.securedFile.Cars.Add(ucKfz.Cars);
                }
            }

            this.securedFile.LastUpdate = DateTime.Now;
            if (!String.IsNullOrEmpty(userName)) this.securedFile.Owner = userName;
            this.securedFile.Save(fileName, password);
            Properties.Settings.Default.LastFilePath = LastFilePath; // save new Usersettings
        }
        private void menuItemGridLayout_Click(object sender, EventArgs e)
        {
            //if (this.pictureBox1.Visible == false) this.pictureBox1.Visible = true;
            //else this.pictureBox1.Visible = false;
            //PictureBox einbauen
        }
        private void menuItemQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   
}