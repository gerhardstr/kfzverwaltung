namespace KfzVerwaltung
{
    partial class UserControlCost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCostsKm = new System.Windows.Forms.TextBox();
            this.textBoxCostsBemerkung = new System.Windows.Forms.TextBox();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.textBoxTankkostenKmGefahren = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenLiter = new System.Windows.Forms.TextBox();
            this.textBoxCostsKosten = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenVerbrauch = new System.Windows.Forms.TextBox();
            this.dateTimePickerCosts = new System.Windows.Forms.DateTimePicker();
            this.panelUcCost = new System.Windows.Forms.Panel();
            this.pictureBoxLiter = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelUcCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCostsKm
            // 
            this.textBoxCostsKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.textBoxCostsKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostsKm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostsKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCostsKm.Location = new System.Drawing.Point(304, 6);
            this.textBoxCostsKm.Name = "textBoxCostsKm";
            this.textBoxCostsKm.Size = new System.Drawing.Size(108, 18);
            this.textBoxCostsKm.TabIndex = 11;
            this.textBoxCostsKm.Leave += new System.EventHandler(this.ValidationKm);
            // 
            // textBoxCostsBemerkung
            // 
            this.textBoxCostsBemerkung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.textBoxCostsBemerkung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostsBemerkung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostsBemerkung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCostsBemerkung.Location = new System.Drawing.Point(418, 6);
            this.textBoxCostsBemerkung.Name = "textBoxCostsBemerkung";
            this.textBoxCostsBemerkung.Size = new System.Drawing.Size(200, 18);
            this.textBoxCostsBemerkung.TabIndex = 12;
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.comboBoxKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Items.AddRange(new object[] {
            "Versicherung",
            "Leasing Rate",
            "Tankkosten",
            "Reifenwechsel",
            "Service",
            "Sonstige Kosten"});
            this.comboBoxKategorie.Location = new System.Drawing.Point(3, 2);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(120, 25);
            this.comboBoxKategorie.TabIndex = 8;
            this.comboBoxKategorie.TextChanged += new System.EventHandler(this.comboBoxKategorie_TextChanged);
            // 
            // textBoxTankkostenKmGefahren
            // 
            this.textBoxTankkostenKmGefahren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.textBoxTankkostenKmGefahren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTankkostenKmGefahren.Enabled = false;
            this.textBoxTankkostenKmGefahren.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenKmGefahren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenKmGefahren.Location = new System.Drawing.Point(673, 6);
            this.textBoxTankkostenKmGefahren.Name = "textBoxTankkostenKmGefahren";
            this.textBoxTankkostenKmGefahren.ReadOnly = true;
            this.textBoxTankkostenKmGefahren.Size = new System.Drawing.Size(43, 18);
            this.textBoxTankkostenKmGefahren.TabIndex = 18;
            this.textBoxTankkostenKmGefahren.Visible = false;
            // 
            // textBoxTankkostenLiter
            // 
            this.textBoxTankkostenLiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.textBoxTankkostenLiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTankkostenLiter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenLiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenLiter.Location = new System.Drawing.Point(624, 6);
            this.textBoxTankkostenLiter.Name = "textBoxTankkostenLiter";
            this.textBoxTankkostenLiter.Size = new System.Drawing.Size(43, 18);
            this.textBoxTankkostenLiter.TabIndex = 17;
            this.textBoxTankkostenLiter.Visible = false;
            this.textBoxTankkostenLiter.Leave += new System.EventHandler(this.ValidationLiter);
            // 
            // textBoxCostsKosten
            // 
            this.textBoxCostsKosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.textBoxCostsKosten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostsKosten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostsKosten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCostsKosten.Location = new System.Drawing.Point(215, 6);
            this.textBoxCostsKosten.MaximumSize = new System.Drawing.Size(100, 25);
            this.textBoxCostsKosten.MinimumSize = new System.Drawing.Size(83, 25);
            this.textBoxCostsKosten.Name = "textBoxCostsKosten";
            this.textBoxCostsKosten.Size = new System.Drawing.Size(83, 18);
            this.textBoxCostsKosten.TabIndex = 10;
            this.textBoxCostsKosten.Leave += new System.EventHandler(this.ValidationKosten);
            // 
            // textBoxTankkostenVerbrauch
            // 
            this.textBoxTankkostenVerbrauch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.textBoxTankkostenVerbrauch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTankkostenVerbrauch.Enabled = false;
            this.textBoxTankkostenVerbrauch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenVerbrauch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenVerbrauch.Location = new System.Drawing.Point(722, 6);
            this.textBoxTankkostenVerbrauch.Name = "textBoxTankkostenVerbrauch";
            this.textBoxTankkostenVerbrauch.ReadOnly = true;
            this.textBoxTankkostenVerbrauch.Size = new System.Drawing.Size(43, 18);
            this.textBoxTankkostenVerbrauch.TabIndex = 19;
            this.textBoxTankkostenVerbrauch.Visible = false;
            // 
            // dateTimePickerCosts
            // 
            this.dateTimePickerCosts.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCosts.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerCosts.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dateTimePickerCosts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCosts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCosts.Location = new System.Drawing.Point(129, 2);
            this.dateTimePickerCosts.Name = "dateTimePickerCosts";
            this.dateTimePickerCosts.Size = new System.Drawing.Size(80, 25);
            this.dateTimePickerCosts.TabIndex = 9;
            // 
            // panelUcCost
            // 
            this.panelUcCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.panelUcCost.Controls.Add(this.comboBoxKategorie);
            this.panelUcCost.Controls.Add(this.dateTimePickerCosts);
            this.panelUcCost.Controls.Add(this.pictureBoxLiter);
            this.panelUcCost.Controls.Add(this.pictureBox3);
            this.panelUcCost.Controls.Add(this.pictureBox1);
            this.panelUcCost.Controls.Add(this.pictureBox2);
            this.panelUcCost.Controls.Add(this.textBoxTankkostenVerbrauch);
            this.panelUcCost.Controls.Add(this.textBoxCostsKosten);
            this.panelUcCost.Controls.Add(this.textBoxCostsKm);
            this.panelUcCost.Controls.Add(this.textBoxTankkostenKmGefahren);
            this.panelUcCost.Controls.Add(this.textBoxCostsBemerkung);
            this.panelUcCost.Controls.Add(this.textBoxTankkostenLiter);
            this.panelUcCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUcCost.Location = new System.Drawing.Point(4, 0);
            this.panelUcCost.Name = "panelUcCost";
            this.panelUcCost.Size = new System.Drawing.Size(769, 25);
            this.panelUcCost.TabIndex = 20;
            // 
            // pictureBoxLiter
            // 
            this.pictureBoxLiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.pictureBoxLiter.Location = new System.Drawing.Point(624, 22);
            this.pictureBoxLiter.Name = "pictureBoxLiter";
            this.pictureBoxLiter.Size = new System.Drawing.Size(43, 1);
            this.pictureBoxLiter.TabIndex = 23;
            this.pictureBoxLiter.TabStop = false;
            this.pictureBoxLiter.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.pictureBox3.Location = new System.Drawing.Point(304, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 1);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.pictureBox1.Location = new System.Drawing.Point(418, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 1);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.pictureBox2.Location = new System.Drawing.Point(215, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 1);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // UserControlCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelUcCost);
            this.Name = "UserControlCost";
            this.Size = new System.Drawing.Size(776, 28);
            this.panelUcCost.ResumeLayout(false);
            this.panelUcCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCostsKm;
        private System.Windows.Forms.TextBox textBoxCostsBemerkung;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
        private System.Windows.Forms.TextBox textBoxTankkostenKmGefahren;
        private System.Windows.Forms.TextBox textBoxTankkostenLiter;
        private System.Windows.Forms.TextBox textBoxCostsKosten;
        private System.Windows.Forms.TextBox textBoxTankkostenVerbrauch;
        private System.Windows.Forms.DateTimePicker dateTimePickerCosts;
        private System.Windows.Forms.Panel panelUcCost;
        private System.Windows.Forms.PictureBox pictureBoxLiter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
