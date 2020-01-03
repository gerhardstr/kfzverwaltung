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
            this.statusLabelUser = new System.Windows.Forms.Label();
            this.StatusLabelSave = new System.Windows.Forms.Label();
            this.statusLabelInformation = new System.Windows.Forms.Label();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.pictureBoxNavigation = new System.Windows.Forms.PictureBox();
            this.pictureBoxBorder = new System.Windows.Forms.PictureBox();
            this.menuItemQuit = new System.Windows.Forms.Button();
            this.menuItemFileSave = new System.Windows.Forms.Button();
            this.menuItemNewKfz = new System.Windows.Forms.Button();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.menuItemFileOpen = new System.Windows.Forms.Button();
            this.panelNavigationBottom = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.menuStrip4KeyControl = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelList = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxHere = new System.Windows.Forms.PictureBox();
            this.panelMotd = new System.Windows.Forms.Panel();
            this.buttonMotd2 = new System.Windows.Forms.Button();
            this.buttonMotd1 = new System.Windows.Forms.Button();
            this.buttonMotd3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxIntro = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorder)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.menuStrip4KeyControl.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHere)).BeginInit();
            this.panelMotd.SuspendLayout();
            this.SuspendLayout();
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
            // timerSave
            // 
            this.timerSave.Interval = 5000;
            this.timerSave.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelNavigation.Controls.Add(this.pictureBoxNavigation);
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
            // pictureBoxNavigation
            // 
            this.pictureBoxNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.pictureBoxNavigation.Location = new System.Drawing.Point(0, 138);
            this.pictureBoxNavigation.Name = "pictureBoxNavigation";
            this.pictureBoxNavigation.Size = new System.Drawing.Size(7, 50);
            this.pictureBoxNavigation.TabIndex = 7;
            this.pictureBoxNavigation.TabStop = false;
            this.pictureBoxNavigation.Visible = false;
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
            this.menuItemFileOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelTop.Controls.Add(this.panelUser);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(140, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(844, 40);
            this.panelTop.TabIndex = 12;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.statusLabelUser);
            this.panelUser.Controls.Add(this.pictureBoxAvatar);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUser.Location = new System.Drawing.Point(644, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(200, 40);
            this.panelUser.TabIndex = 0;
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
            this.pictureBoxAvatar.Click += new System.EventHandler(this.pictureBoxAvatar_Click);
            // 
            // menuStrip4KeyControl
            // 
            this.menuStrip4KeyControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem});
            this.menuStrip4KeyControl.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4KeyControl.Name = "menuStrip4KeyControl";
            this.menuStrip4KeyControl.Size = new System.Drawing.Size(984, 24);
            this.menuStrip4KeyControl.TabIndex = 14;
            this.menuStrip4KeyControl.Text = "menuStrip1";
            this.menuStrip4KeyControl.Visible = false;
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem1,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.neuToolStripMenuItem.Text = "KeyControl";
            // 
            // neuToolStripMenuItem1
            // 
            this.neuToolStripMenuItem1.Name = "neuToolStripMenuItem1";
            this.neuToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.neuToolStripMenuItem1.Text = "Neu";
            this.neuToolStripMenuItem1.Click += new System.EventHandler(this.menuItemNewKfz_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.menuItemFileSave_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.menuItemQuit_Click);
            // 
            // panelList
            // 
            this.panelList.AutoScroll = true;
            this.panelList.AutoSize = true;
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelList.BackgroundImage = global::KfzVerwaltung.Properties.Resources.background;
            this.panelList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelList.Controls.Add(this.pictureBoxHere);
            this.panelList.Controls.Add(this.panelMotd);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(140, 40);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(844, 371);
            this.panelList.TabIndex = 15;
            // 
            // pictureBoxHere
            // 
            this.pictureBoxHere.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHere.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHere.Image = global::KfzVerwaltung.Properties.Resources.StartHere2;
            this.pictureBoxHere.Location = new System.Drawing.Point(3, 100);
            this.pictureBoxHere.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.pictureBoxHere.Name = "pictureBoxHere";
            this.pictureBoxHere.Size = new System.Drawing.Size(208, 202);
            this.pictureBoxHere.TabIndex = 311;
            this.pictureBoxHere.TabStop = false;
            // 
            // panelMotd
            // 
            this.panelMotd.Controls.Add(this.buttonMotd2);
            this.panelMotd.Controls.Add(this.buttonMotd1);
            this.panelMotd.Controls.Add(this.buttonMotd3);
            this.panelMotd.Controls.Add(this.textBox3);
            this.panelMotd.Controls.Add(this.textBox5);
            this.panelMotd.Controls.Add(this.textBoxIntro);
            this.panelMotd.Controls.Add(this.textBox7);
            this.panelMotd.Controls.Add(this.textBox6);
            this.panelMotd.Controls.Add(this.textBox4);
            this.panelList.SetFlowBreak(this.panelMotd, true);
            this.panelMotd.Location = new System.Drawing.Point(234, 60);
            this.panelMotd.Margin = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.panelMotd.Name = "panelMotd";
            this.panelMotd.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelMotd.Size = new System.Drawing.Size(354, 225);
            this.panelMotd.TabIndex = 307;
            // 
            // buttonMotd2
            // 
            this.buttonMotd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonMotd2.FlatAppearance.BorderSize = 0;
            this.buttonMotd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMotd2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMotd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.buttonMotd2.Location = new System.Drawing.Point(7, 66);
            this.buttonMotd2.Name = "buttonMotd2";
            this.buttonMotd2.Size = new System.Drawing.Size(25, 25);
            this.buttonMotd2.TabIndex = 310;
            this.buttonMotd2.TabStop = false;
            this.buttonMotd2.Text = "2";
            this.buttonMotd2.UseVisualStyleBackColor = false;
            // 
            // buttonMotd1
            // 
            this.buttonMotd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonMotd1.FlatAppearance.BorderSize = 0;
            this.buttonMotd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMotd1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMotd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.buttonMotd1.Location = new System.Drawing.Point(7, 16);
            this.buttonMotd1.Name = "buttonMotd1";
            this.buttonMotd1.Size = new System.Drawing.Size(25, 25);
            this.buttonMotd1.TabIndex = 308;
            this.buttonMotd1.TabStop = false;
            this.buttonMotd1.Text = "1";
            this.buttonMotd1.UseVisualStyleBackColor = false;
            // 
            // buttonMotd3
            // 
            this.buttonMotd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonMotd3.FlatAppearance.BorderSize = 0;
            this.buttonMotd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMotd3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMotd3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.buttonMotd3.Location = new System.Drawing.Point(7, 127);
            this.buttonMotd3.Name = "buttonMotd3";
            this.buttonMotd3.Size = new System.Drawing.Size(25, 25);
            this.buttonMotd3.TabIndex = 309;
            this.buttonMotd3.TabStop = false;
            this.buttonMotd3.Text = "3";
            this.buttonMotd3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(38, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Beginnen Sie eine neue Liste";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.Location = new System.Drawing.Point(38, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(303, 22);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Wussten Sie schon...";
            // 
            // textBoxIntro
            // 
            this.textBoxIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBoxIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIntro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxIntro.Location = new System.Drawing.Point(38, 146);
            this.textBoxIntro.Multiline = true;
            this.textBoxIntro.Name = "textBoxIntro";
            this.textBoxIntro.Size = new System.Drawing.Size(303, 68);
            this.textBoxIntro.TabIndex = 1;
            this.textBoxIntro.Text = "Beim Speichern Ihrer Fahrzeuge wird auch die Größe und Position des Anwendungsfen" +
    "sters gespeichert. So können Sie die Position der Anwendung personalisieren.\r\n";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(38, 91);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(303, 20);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "Sie können eine Liste ihrer Fahrzeuge öffnen. \r\n";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(38, 35);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(315, 27);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Sie können eine neue Liste mit Fahrzeugen anlegen.\r\n";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(38, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(303, 22);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Verwalten Sie Ihre Fahrzeuge";
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
            this.Controls.Add(this.menuStrip4KeyControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip4KeyControl;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kfz Verwaltung";
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorder)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.menuStrip4KeyControl.ResumeLayout(false);
            this.menuStrip4KeyControl.PerformLayout();
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHere)).EndInit();
            this.panelMotd.ResumeLayout(false);
            this.panelMotd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Label statusLabelUser;
		private System.Windows.Forms.Label StatusLabelSave;
		private System.Windows.Forms.Label statusLabelInformation;
		private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelNavigationBottom;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button menuItemFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxBorder;
        private System.Windows.Forms.Button menuItemQuit;
        private System.Windows.Forms.Button menuItemFileSave;
        private System.Windows.Forms.Button menuItemNewKfz;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.PictureBox pictureBoxNavigation;
        private System.Windows.Forms.MenuStrip menuStrip4KeyControl;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelList;
        private System.Windows.Forms.PictureBox pictureBoxHere;
        private System.Windows.Forms.Panel panelMotd;
        private System.Windows.Forms.Button buttonMotd2;
        private System.Windows.Forms.Button buttonMotd1;
        private System.Windows.Forms.Button buttonMotd3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBoxIntro;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
    }
}

