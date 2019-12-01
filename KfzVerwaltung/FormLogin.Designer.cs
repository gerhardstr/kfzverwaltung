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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelBenutzer = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxBenutzer = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.buttonLoginOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBenutzer
            // 
            this.labelBenutzer.AutoSize = true;
            this.labelBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenutzer.Location = new System.Drawing.Point(230, 30);
            this.labelBenutzer.Name = "labelBenutzer";
            this.labelBenutzer.Size = new System.Drawing.Size(68, 16);
            this.labelBenutzer.TabIndex = 0;
            this.labelBenutzer.Text = "Benutzer";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswort.Location = new System.Drawing.Point(233, 94);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(71, 16);
            this.labelPasswort.TabIndex = 1;
            this.labelPasswort.Text = "Passwort";
            // 
            // textBoxBenutzer
            // 
            this.textBoxBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBenutzer.Location = new System.Drawing.Point(233, 47);
            this.textBoxBenutzer.Name = "textBoxBenutzer";
            this.textBoxBenutzer.Size = new System.Drawing.Size(170, 22);
            this.textBoxBenutzer.TabIndex = 2;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswort.Location = new System.Drawing.Point(233, 111);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.PasswordChar = '*';
            this.textBoxPasswort.Size = new System.Drawing.Size(170, 22);
            this.textBoxPasswort.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLoginCancel
            // 
            this.buttonLoginCancel.Location = new System.Drawing.Point(233, 156);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginCancel.TabIndex = 5;
            this.buttonLoginCancel.Text = "Abbrechen";
            this.buttonLoginCancel.UseVisualStyleBackColor = true;
            this.buttonLoginCancel.Click += new System.EventHandler(this.buttonLoginCancel_Click);
            // 
            // buttonLoginOk
            // 
            this.buttonLoginOk.Location = new System.Drawing.Point(328, 156);
            this.buttonLoginOk.Name = "buttonLoginOk";
            this.buttonLoginOk.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginOk.TabIndex = 6;
            this.buttonLoginOk.Text = "OK";
            this.buttonLoginOk.UseVisualStyleBackColor = true;
            this.buttonLoginOk.Click += new System.EventHandler(this.buttonLoginOk_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(433, 191);
            this.Controls.Add(this.buttonLoginOk);
            this.Controls.Add(this.buttonLoginCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxBenutzer);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelBenutzer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Anmeldung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBenutzer;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxBenutzer;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoginCancel;
        private System.Windows.Forms.Button buttonLoginOk;
    }
}