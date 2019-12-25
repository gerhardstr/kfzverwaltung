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
            this.textBoxCostsKosten = new System.Windows.Forms.TextBox();
            this.textBoxCostsBemerkung = new System.Windows.Forms.TextBox();
            this.textBoxCostsKm = new System.Windows.Forms.TextBox();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCosts = new System.Windows.Forms.DateTimePicker();
            this.panelCosts = new System.Windows.Forms.Panel();
            this.panelFuelCosts = new System.Windows.Forms.Panel();
            this.textBoxTankkostenKategorie = new System.Windows.Forms.TextBox();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenLiter = new System.Windows.Forms.TextBox();
            this.textBoxKmGefahren = new System.Windows.Forms.TextBox();
            this.dateTimePickerTankkosten = new System.Windows.Forms.DateTimePicker();
            this.textBoxTankkostenKm = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenKosten = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenBemerkung = new System.Windows.Forms.TextBox();
            this.panelCosts.SuspendLayout();
            this.panelFuelCosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCostsKosten
            // 
            this.textBoxCostsKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostsKosten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCostsKosten.Location = new System.Drawing.Point(245, 3);
            this.textBoxCostsKosten.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxCostsKosten.Name = "textBoxCostsKosten";
            this.textBoxCostsKosten.Size = new System.Drawing.Size(83, 22);
            this.textBoxCostsKosten.TabIndex = 10;
            // 
            // textBoxCostsBemerkung
            // 
            this.textBoxCostsBemerkung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostsBemerkung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCostsBemerkung.Location = new System.Drawing.Point(448, 3);
            this.textBoxCostsBemerkung.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxCostsBemerkung.Name = "textBoxCostsBemerkung";
            this.textBoxCostsBemerkung.Size = new System.Drawing.Size(340, 22);
            this.textBoxCostsBemerkung.TabIndex = 12;
            // 
            // textBoxCostsKm
            // 
            this.textBoxCostsKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostsKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCostsKm.Location = new System.Drawing.Point(334, 3);
            this.textBoxCostsKm.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxCostsKm.Name = "textBoxCostsKm";
            this.textBoxCostsKm.Size = new System.Drawing.Size(108, 22);
            this.textBoxCostsKm.TabIndex = 11;
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Items.AddRange(new object[] {
            "Versicherung",
            "Leasing Rate",
            "Tankkosten",
            "Reifenwechsel",
            "Service",
            "Sonstige Kosten"});
            this.comboBoxKategorie.Location = new System.Drawing.Point(3, 3);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(141, 24);
            this.comboBoxKategorie.TabIndex = 8;
            // 
            // dateTimePickerCosts
            // 
            this.dateTimePickerCosts.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCosts.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCosts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCosts.Location = new System.Drawing.Point(149, 3);
            this.dateTimePickerCosts.Name = "dateTimePickerCosts";
            this.dateTimePickerCosts.Size = new System.Drawing.Size(91, 22);
            this.dateTimePickerCosts.TabIndex = 9;
            // 
            // panelCosts
            // 
            this.panelCosts.Controls.Add(this.dateTimePickerCosts);
            this.panelCosts.Controls.Add(this.textBoxCostsKosten);
            this.panelCosts.Controls.Add(this.comboBoxKategorie);
            this.panelCosts.Controls.Add(this.textBoxCostsBemerkung);
            this.panelCosts.Controls.Add(this.textBoxCostsKm);
            this.panelCosts.Location = new System.Drawing.Point(0, 0);
            this.panelCosts.Name = "panelCosts";
            this.panelCosts.Size = new System.Drawing.Size(937, 28);
            this.panelCosts.TabIndex = 13;
            // 
            // panelFuelCosts
            // 
            this.panelFuelCosts.Controls.Add(this.textBoxTankkostenKategorie);
            this.panelFuelCosts.Controls.Add(this.textBoxVerbrauch);
            this.panelFuelCosts.Controls.Add(this.textBoxTankkostenLiter);
            this.panelFuelCosts.Controls.Add(this.textBoxKmGefahren);
            this.panelFuelCosts.Controls.Add(this.dateTimePickerTankkosten);
            this.panelFuelCosts.Controls.Add(this.textBoxTankkostenKm);
            this.panelFuelCosts.Controls.Add(this.textBoxTankkostenKosten);
            this.panelFuelCosts.Controls.Add(this.textBoxTankkostenBemerkung);
            this.panelFuelCosts.Location = new System.Drawing.Point(0, 27);
            this.panelFuelCosts.Name = "panelFuelCosts";
            this.panelFuelCosts.Size = new System.Drawing.Size(937, 28);
            this.panelFuelCosts.TabIndex = 14;
            // 
            // textBoxTankkostenKategorie
            // 
            this.textBoxTankkostenKategorie.Enabled = false;
            this.textBoxTankkostenKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenKategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenKategorie.Location = new System.Drawing.Point(3, 3);
            this.textBoxTankkostenKategorie.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenKategorie.Name = "textBoxTankkostenKategorie";
            this.textBoxTankkostenKategorie.ReadOnly = true;
            this.textBoxTankkostenKategorie.Size = new System.Drawing.Size(141, 22);
            this.textBoxTankkostenKategorie.TabIndex = 23;
            this.textBoxTankkostenKategorie.Text = "Tankkosten";
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Enabled = false;
            this.textBoxVerbrauch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVerbrauch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVerbrauch.Location = new System.Drawing.Point(891, 3);
            this.textBoxVerbrauch.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.ReadOnly = true;
            this.textBoxVerbrauch.Size = new System.Drawing.Size(43, 22);
            this.textBoxVerbrauch.TabIndex = 19;
            // 
            // textBoxTankkostenLiter
            // 
            this.textBoxTankkostenLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenLiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenLiter.Location = new System.Drawing.Point(794, 3);
            this.textBoxTankkostenLiter.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenLiter.Name = "textBoxTankkostenLiter";
            this.textBoxTankkostenLiter.Size = new System.Drawing.Size(43, 22);
            this.textBoxTankkostenLiter.TabIndex = 17;
            this.textBoxTankkostenLiter.TextChanged += new System.EventHandler(this.textBoxTankkostenLiter_TextChanged);
            // 
            // textBoxKmGefahren
            // 
            this.textBoxKmGefahren.Enabled = false;
            this.textBoxKmGefahren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKmGefahren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxKmGefahren.Location = new System.Drawing.Point(843, 3);
            this.textBoxKmGefahren.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxKmGefahren.Name = "textBoxKmGefahren";
            this.textBoxKmGefahren.ReadOnly = true;
            this.textBoxKmGefahren.Size = new System.Drawing.Size(43, 22);
            this.textBoxKmGefahren.TabIndex = 18;
            // 
            // dateTimePickerTankkosten
            // 
            this.dateTimePickerTankkosten.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTankkosten.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePickerTankkosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTankkosten.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTankkosten.Location = new System.Drawing.Point(149, 3);
            this.dateTimePickerTankkosten.Name = "dateTimePickerTankkosten";
            this.dateTimePickerTankkosten.Size = new System.Drawing.Size(91, 22);
            this.dateTimePickerTankkosten.TabIndex = 13;
            // 
            // textBoxTankkostenKm
            // 
            this.textBoxTankkostenKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenKm.Location = new System.Drawing.Point(334, 3);
            this.textBoxTankkostenKm.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenKm.Name = "textBoxTankkostenKm";
            this.textBoxTankkostenKm.Size = new System.Drawing.Size(108, 22);
            this.textBoxTankkostenKm.TabIndex = 15;
            // 
            // textBoxTankkostenKosten
            // 
            this.textBoxTankkostenKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenKosten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenKosten.Location = new System.Drawing.Point(245, 3);
            this.textBoxTankkostenKosten.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenKosten.Name = "textBoxTankkostenKosten";
            this.textBoxTankkostenKosten.Size = new System.Drawing.Size(83, 22);
            this.textBoxTankkostenKosten.TabIndex = 14;
            // 
            // textBoxTankkostenBemerkung
            // 
            this.textBoxTankkostenBemerkung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenBemerkung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenBemerkung.Location = new System.Drawing.Point(448, 3);
            this.textBoxTankkostenBemerkung.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenBemerkung.Name = "textBoxTankkostenBemerkung";
            this.textBoxTankkostenBemerkung.Size = new System.Drawing.Size(340, 22);
            this.textBoxTankkostenBemerkung.TabIndex = 16;
            // 
            // UserControlCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFuelCosts);
            this.Controls.Add(this.panelCosts);
            this.Name = "UserControlCost";
            this.Size = new System.Drawing.Size(939, 139);
            this.panelCosts.ResumeLayout(false);
            this.panelCosts.PerformLayout();
            this.panelFuelCosts.ResumeLayout(false);
            this.panelFuelCosts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCostsKosten;
        private System.Windows.Forms.TextBox textBoxCostsBemerkung;
        private System.Windows.Forms.TextBox textBoxCostsKm;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
		private System.Windows.Forms.DateTimePicker dateTimePickerCosts;
        private System.Windows.Forms.Panel panelCosts;
        private System.Windows.Forms.Panel panelFuelCosts;
        private System.Windows.Forms.TextBox textBoxTankkostenKategorie;
        private System.Windows.Forms.TextBox textBoxVerbrauch;
        private System.Windows.Forms.TextBox textBoxTankkostenLiter;
        private System.Windows.Forms.TextBox textBoxKmGefahren;
        private System.Windows.Forms.DateTimePicker dateTimePickerTankkosten;
        private System.Windows.Forms.TextBox textBoxTankkostenKm;
        private System.Windows.Forms.TextBox textBoxTankkostenKosten;
        private System.Windows.Forms.TextBox textBoxTankkostenBemerkung;
    }
}
