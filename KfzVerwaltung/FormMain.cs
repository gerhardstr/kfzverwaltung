using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			if (Properties.Settings.Default.WindowLocation != null) this.Location = Properties.Settings.Default.WindowLocation;
			if (Properties.Settings.Default.WindowSize != null) this.Size = Properties.Settings.Default.WindowSize;

			while (!dialog.FileName.ToLower().EndsWith(".xml"))
			{
				if (dialog.ShowDialog() == DialogResult.OK);
				if (!dialog.FileName.ToLower().EndsWith(".xml")) MessageBox.Show("Bitte wählen Sie eine .xml-Datei aus.", "Falsche Dateiauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	if (dialog.ShowDialog() == DialogResult.Cancel) Application.Exit();
			}
			{
				FormLogin loginForm = new FormLogin();  // check user access
				if (loginForm.ShowDialog() == DialogResult.OK)
				{


					panelList.Controls.Clear();
					try
					{
						this.securedFile = SecuredFile.Read(dialog.FileName, loginForm.Password);
						if (this.securedFile.Owner == loginForm.Username)
						{
							this.masterPassword = loginForm.Password;
							foreach (Car car in this.securedFile.Cars) LoadUserControl(car);
							this.statusLabelInfo.Text = "Benutzer: " + loginForm.Username.ToString() + " | Dateipfad: " + dialog.FileName.ToString(); // statusstrip is required
							this.statusStripUserInformation.Text = dialog.FileName; // required for menuItemFileSave_Click
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
				LoadUserControl(kfzForm.Car);
			}
		}
		private void LoadUserControl(Car car)
		{
			UserControl userControl = null;
			userControl = new UserControlKfz(car);

			int ucTop = 0;
			if (this.panelList.Controls.Count > 0)
			//Styling
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
					this.securedFile.Cars.Add(ucKfz.Car);
				}
			}

			this.securedFile.LastUpdate = DateTime.Now;
			if (!String.IsNullOrEmpty(userName)) this.securedFile.Owner = userName;
			this.securedFile.Save(fileName, password);
			toolStripStatusLabelSave.Text = "Speichern erfolgreich durchgeführt.";

			this.t1.Enabled = true;  // timer for fade out

			Properties.Settings.Default.LastFilePath = LastFilePath; // save new Usersettings
			Properties.Settings.Default.WindowLocation = this.Location;
			Properties.Settings.Default.WindowSize = this.Size;
		}
		private void menuItemGridLayout_Click(object sender, EventArgs e)
		{
			//if (this.pictureBox1.Visible == false) this.pictureBox1.Visible = true;
			//else this.pictureBox1.Visible = false;
			//PictureBox einbauen
		}

		private void menuItemQuit_Click(object sender, EventArgs e)
		{

			Properties.Settings.Default.WindowLocation = this.Location; //save Usersettings
			Properties.Settings.Default.WindowSize = this.Size;
			Application.Exit();
		}

		private void t1_Tick(object sender, EventArgs e)
		{
			Color myForeColor = this.toolStripStatusLabelSave.ForeColor;

			for (int i = 255; i >= 0; i--)
			{
				this.toolStripStatusLabelSave.ForeColor = Color.FromArgb(i, myForeColor);
				Thread.Sleep(20);
			}
			toolStripStatusLabelSave.Text = "";
			this.t1.Enabled = false;
		}
    }
}