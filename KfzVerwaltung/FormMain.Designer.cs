namespace KfzVerwaltung
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabelUser = new System.Windows.Forms.Label();
            this.StatusLabelSave = new System.Windows.Forms.Label();
            this.statusLabelInformation = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.pictureBoxBorder = new System.Windows.Forms.PictureBox();
            this.menuItemQuit = new System.Windows.Forms.Button();
            this.menuItemFileSave = new System.Windows.Forms.Button();
            this.menuItemNewKfz = new System.Windows.Forms.Button();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.menuItemFileOpen = new System.Windows.Forms.Button();
            this.panelNavigationBottom = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorder)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(764, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum Zulassung";
            // 
            // statusLabelUser
            // 
            this.statusLabelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusLabelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusLabelUser.Location = new System.Drawing.Point(-44, 0);
            this.statusLabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabelUser.Name = "statusLabelUser";
            this.statusLabelUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabelUser.Size = new System.Drawing.Size(200, 40);
            this.statusLabelUser.TabIndex = 8;
            this.statusLabelUser.Text = "StatusBenutzer";
            this.statusLabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabelUser.Visible = false;
            // 
            // StatusLabelSave
            // 
            this.StatusLabelSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabelSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabelSave.Location = new System.Drawing.Point(340, 21);
            this.StatusLabelSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabelSave.Name = "StatusLabelSave";
            this.StatusLabelSave.Size = new System.Drawing.Size(500, 17);
            this.StatusLabelSave.TabIndex = 9;
            this.StatusLabelSave.Text = "StatusSave";
            this.StatusLabelSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusLabelSave.Visible = false;
            // 
            // statusLabelInformation
            // 
            this.statusLabelInformation.AutoSize = true;
            this.statusLabelInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelInformation.Location = new System.Drawing.Point(8, 21);
            this.statusLabelInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabelInformation.Name = "statusLabelInformation";
            this.statusLabelInformation.Size = new System.Drawing.Size(141, 17);
            this.statusLabelInformation.TabIndex = 10;
            this.statusLabelInformation.Text = "StatusLabelInformation";
            this.statusLabelInformation.Visible = false;
            // 
            // t1
            // 
            this.t1.Interval = 5000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelNavigation.Controls.Add(this.pictureBoxBorder);
            this.panelNavigation.Controls.Add(this.menuItemQuit);
            this.panelNavigation.Controls.Add(this.menuItemFileSave);
            this.panelNavigation.Controls.Add(this.menuItemNewKfz);
            this.panelNavigation.Controls.Add(this.buttonLogo);
            this.panelNavigation.Controls.Add(this.menuItemFileOpen);
            this.panelNavigation.Controls.Add(this.panelNavigationBottom);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(140, 461);
            this.panelNavigation.TabIndex = 0;
            // 
            // pictureBoxBorder
            // 
            this.pictureBoxBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.pictureBoxBorder.Location = new System.Drawing.Point(32, 375);
            this.pictureBoxBorder.Name = "pictureBoxBorder";
            this.pictureBoxBorder.Size = new System.Drawing.Size(74, 1);
            this.pictureBoxBorder.TabIndex = 3;
            this.pictureBoxBorder.TabStop = false;
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.FlatAppearance.BorderSize = 0;
            this.menuItemQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuItemQuit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.menuItemQuit.Image = global::KfzVerwaltung.Properties.Resources.exit_20px;
            this.menuItemQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemQuit.Location = new System.Drawing.Point(3, 306);
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.menuItemQuit.Size = new System.Drawing.Size(135, 50);
            this.menuItemQuit.TabIndex = 6;
            this.menuItemQuit.Text = "  Beenden";
            this.menuItemQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuItemQuit.UseVisualStyleBackColor = true;
            this.menuItemQuit.Click += new System.EventHandler(this.menuItemQuit_Click);
            // 
            // menuItemFileSave
            // 
            this.menuItemFileSave.FlatAppearance.BorderSize = 0;
            this.menuItemFileSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuItemFileSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemFileSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.menuItemFileSave.Image = global::KfzVerwaltung.Properties.Resources.save_20px;
            this.menuItemFileSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemFileSave.Location = new System.Drawing.Point(3, 250);
            this.menuItemFileSave.Name = "menuItemFileSave";
            this.menuItemFileSave.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.menuItemFileSave.Size = new System.Drawing.Size(135, 50);
            this.menuItemFileSave.TabIndex = 5;
            this.menuItemFileSave.Text = "  Speichern";
            this.menuItemFileSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemFileSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuItemFileSave.UseVisualStyleBackColor = true;
            this.menuItemFileSave.Click += new System.EventHandler(this.menuItemFileSave_Click);
            // 
            // menuItemNewKfz
            // 
            this.menuItemNewKfz.FlatAppearance.BorderSize = 0;
            this.menuItemNewKfz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuItemNewKfz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemNewKfz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.menuItemNewKfz.Image = global::KfzVerwaltung.Properties.Resources.car_25px1;
            this.menuItemNewKfz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemNewKfz.Location = new System.Drawing.Point(3, 194);
            this.menuItemNewKfz.Name = "menuItemNewKfz";
            this.menuItemNewKfz.Padding = new System.Windows.Forms.Padding(5, 10, 9, 10);
            this.menuItemNewKfz.Size = new System.Drawing.Size(135, 50);
            this.menuItemNewKfz.TabIndex = 4;
            this.menuItemNewKfz.Text = "  Neues Kfz";
            this.menuItemNewKfz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemNewKfz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuItemNewKfz.UseVisualStyleBackColor = true;
            this.menuItemNewKfz.Click += new System.EventHandler(this.menuItemNewKfz_Click);
            // 
            // buttonLogo
            // 
            this.buttonLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.buttonLogo.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogo.Image")));
            this.buttonLogo.Location = new System.Drawing.Point(0, 34);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(140, 70);
            this.buttonLogo.TabIndex = 2;
            this.buttonLogo.Text = "Kfz Verwaltung";
            this.buttonLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogo.UseVisualStyleBackColor = true;
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.FlatAppearance.BorderSize = 0;
            this.menuItemFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuItemFileOpen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemFileOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.menuItemFileOpen.Image = global::KfzVerwaltung.Properties.Resources.opened_folder_20px;
            this.menuItemFileOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemFileOpen.Location = new System.Drawing.Point(3, 138);
            this.menuItemFileOpen.Name = "menuItemFileOpen";
            this.menuItemFileOpen.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.menuItemFileOpen.Size = new System.Drawing.Size(135, 50);
            this.menuItemFileOpen.TabIndex = 2;
            this.menuItemFileOpen.Text = "  Liste öffnen";
            this.menuItemFileOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemFileOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuItemFileOpen.UseVisualStyleBackColor = true;
            this.menuItemFileOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // panelNavigationBottom
            // 
            this.panelNavigationBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelNavigationBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigationBottom.Location = new System.Drawing.Point(0, 411);
            this.panelNavigationBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavigationBottom.Name = "panelNavigationBottom";
            this.panelNavigationBottom.Size = new System.Drawing.Size(140, 50);
            this.panelNavigationBottom.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.panelBottom.Controls.Add(this.statusLabelInformation);
            this.panelBottom.Controls.Add(this.StatusLabelSave);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(140, 411);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelBottom.Size = new System.Drawing.Size(844, 50);
            this.panelBottom.TabIndex = 11;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(140, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(844, 40);
            this.panelTop.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusLabelUser);
            this.panel1.Controls.Add(this.pictureBoxAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(644, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAvatar.Image = global::KfzVerwaltung.Properties.Resources.male_user_225px;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(156, 0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(44, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar.TabIndex = 1;
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.Visible = false;
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(140, 40);
            this.panelList.Margin = new System.Windows.Forms.Padding(4);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(844, 371);
            this.panelList.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kfz Verwaltung";
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorder)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label statusLabelUser;
		private System.Windows.Forms.Label StatusLabelSave;
		private System.Windows.Forms.Label statusLabelInformation;
		private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelNavigationBottom;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button menuItemFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxBorder;
        private System.Windows.Forms.Button menuItemQuit;
        private System.Windows.Forms.Button menuItemFileSave;
        private System.Windows.Forms.Button menuItemNewKfz;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
    }
}

