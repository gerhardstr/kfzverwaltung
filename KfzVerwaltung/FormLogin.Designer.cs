namespace KfzVerwaltung
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBenutzer = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxBenutzer = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.buttonLoginOk = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBenutzer
            // 
            this.labelBenutzer.AutoSize = true;
            this.labelBenutzer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenutzer.Location = new System.Drawing.Point(12, 154);
            this.labelBenutzer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBenutzer.Name = "labelBenutzer";
            this.labelBenutzer.Size = new System.Drawing.Size(58, 17);
            this.labelBenutzer.TabIndex = 0;
            this.labelBenutzer.Text = "Benutzer";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswort.Location = new System.Drawing.Point(12, 235);
            this.labelPasswort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(60, 17);
            this.labelPasswort.TabIndex = 1;
            this.labelPasswort.Text = "Passwort";
            // 
            // textBoxBenutzer
            // 
            this.textBoxBenutzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBoxBenutzer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBenutzer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBenutzer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBenutzer.Location = new System.Drawing.Point(15, 175);
            this.textBoxBenutzer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBenutzer.Name = "textBoxBenutzer";
            this.textBoxBenutzer.Size = new System.Drawing.Size(215, 18);
            this.textBoxBenutzer.TabIndex = 1;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBoxPasswort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPasswort.Location = new System.Drawing.Point(15, 255);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.PasswordChar = '*';
            this.textBoxPasswort.Size = new System.Drawing.Size(215, 18);
            this.textBoxPasswort.TabIndex = 2;
            // 
            // buttonLoginCancel
            // 
            this.buttonLoginCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.buttonLoginCancel.FlatAppearance.BorderSize = 0;
            this.buttonLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.buttonLoginCancel.Location = new System.Drawing.Point(15, 300);
            this.buttonLoginCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonLoginCancel.TabIndex = 3;
            this.buttonLoginCancel.Text = "Abbrechen";
            this.buttonLoginCancel.UseVisualStyleBackColor = false;
            this.buttonLoginCancel.Click += new System.EventHandler(this.buttonLoginCancel_Click);
            // 
            // buttonLoginOk
            // 
            this.buttonLoginOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.buttonLoginOk.FlatAppearance.BorderSize = 0;
            this.buttonLoginOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.buttonLoginOk.Location = new System.Drawing.Point(130, 300);
            this.buttonLoginOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoginOk.Name = "buttonLoginOk";
            this.buttonLoginOk.Size = new System.Drawing.Size(100, 30);
            this.buttonLoginOk.TabIndex = 4;
            this.buttonLoginOk.Text = "Login";
            this.buttonLoginOk.UseVisualStyleBackColor = false;
            this.buttonLoginOk.Click += new System.EventHandler(this.buttonLoginOk_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.pictureBox2);
            this.panelBackground.Controls.Add(this.labelBenutzer);
            this.panelBackground.Controls.Add(this.pictureBox1);
            this.panelBackground.Controls.Add(this.labelPasswort);
            this.panelBackground.Controls.Add(this.textBoxBenutzer);
            this.panelBackground.Controls.Add(this.buttonLoginOk);
            this.panelBackground.Controls.Add(this.textBoxPasswort);
            this.panelBackground.Controls.Add(this.buttonLoginCancel);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(250, 360);
            this.panelBackground.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.pictureBox2.Location = new System.Drawing.Point(15, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 1);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.pictureBox1.Location = new System.Drawing.Point(15, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 1);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.panelLogin.BackgroundImage = global::KfzVerwaltung.Properties.Resources.logo_auto;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(250, 130);
            this.panelLogin.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(250, 360);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBenutzer;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxBenutzer;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Button buttonLoginCancel;
        private System.Windows.Forms.Button buttonLoginOk;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelBackground;
    }
}