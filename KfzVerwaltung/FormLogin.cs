using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KfzVerwaltung
{
	public partial class FormLogin : Form
	{
        #region constructor
        public FormLogin()
		{
			InitializeComponent();
		}
        #endregion

        #region properties
        public string Username
		{
			get { return this.textBoxBenutzer.Text; }
		}

		public string Password
		{
			get { return this.textBoxPasswort.Text; }
		}
        #endregion

        #region methods
        private void buttonLoginOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void buttonLoginCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
        private void textBoxPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLoginOk_Click(this, new EventArgs());
        }
        #endregion
    }
}
