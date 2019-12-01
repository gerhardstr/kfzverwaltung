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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewKfz = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGridLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelList = new System.Windows.Forms.Panel();
            this.statusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripUserInformation = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStripUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.editToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileOpen,
            this.menuItemFileSave,
            this.menuItemQuit});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuItemFileOpen.Image")));
            this.menuItemFileOpen.Name = "menuItemFileOpen";
            this.menuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemFileOpen.Size = new System.Drawing.Size(183, 22);
            this.menuItemFileOpen.Text = "Datei Öffnen";
            this.menuItemFileOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // menuItemFileSave
            // 
            this.menuItemFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuItemFileSave.Image")));
            this.menuItemFileSave.Name = "menuItemFileSave";
            this.menuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemFileSave.Size = new System.Drawing.Size(183, 22);
            this.menuItemFileSave.Text = "Speichern";
            this.menuItemFileSave.Click += new System.EventHandler(this.menuItemFileSave_Click);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Image = ((System.Drawing.Image)(resources.GetObject("menuItemQuit.Image")));
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemQuit.Size = new System.Drawing.Size(183, 22);
            this.menuItemQuit.Text = "Beenden";
            this.menuItemQuit.Click += new System.EventHandler(this.menuItemQuit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewKfz});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // menuItemNewKfz
            // 
            this.menuItemNewKfz.Image = global::KfzVerwaltung.Properties.Resources.NewFile_16x;
            this.menuItemNewKfz.Name = "menuItemNewKfz";
            this.menuItemNewKfz.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNewKfz.Size = new System.Drawing.Size(221, 22);
            this.menuItemNewKfz.Text = "Neues Kfz erfassen";
            this.menuItemNewKfz.Click += new System.EventHandler(this.menuItemNewKfz_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGridLayout});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // menuItemGridLayout
            // 
            this.menuItemGridLayout.Image = global::KfzVerwaltung.Properties.Resources.GridApplication_16x;
            this.menuItemGridLayout.Name = "menuItemGridLayout";
            this.menuItemGridLayout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuItemGridLayout.Size = new System.Drawing.Size(177, 22);
            this.menuItemGridLayout.Text = "Grid Layout";
            this.menuItemGridLayout.Click += new System.EventHandler(this.menuItemGridLayout_Click);
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.AutoScroll = true;
            this.panelList.Location = new System.Drawing.Point(2, 47);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(797, 300);
            this.panelList.TabIndex = 2;
            // 
            // statusLabelInfo
            // 
            this.statusLabelInfo.Name = "statusLabelInfo";
            this.statusLabelInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStripUserInformation
            // 
            this.statusStripUserInformation.BackColor = System.Drawing.Color.LightGray;
            this.statusStripUserInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelInfo});
            this.statusStripUserInformation.Location = new System.Drawing.Point(0, 350);
            this.statusStripUserInformation.Name = "statusStripUserInformation";
            this.statusStripUserInformation.Size = new System.Drawing.Size(800, 22);
            this.statusStripUserInformation.TabIndex = 1;
            this.statusStripUserInformation.Text = "statusStripUserInformation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(135, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(380, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum Zulassung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(240, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kennzeichen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(530, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gesamtkosten";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.statusStripUserInformation);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Kfz Verwaltung";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStripUserInformation.ResumeLayout(false);
            this.statusStripUserInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewKfz;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemGridLayout;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelInfo;
        private System.Windows.Forms.StatusStrip statusStripUserInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

