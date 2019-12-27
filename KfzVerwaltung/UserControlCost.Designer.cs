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
            this.textBoxTankkostenVerbrauch = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenLiter = new System.Windows.Forms.TextBox();
            this.textBoxTankkostenKmGefahren = new System.Windows.Forms.TextBox();
            this.panelCosts.SuspendLayout();
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
            this.comboBoxKategorie.TextChanged += new System.EventHandler(this.comboBoxKategorie_TextChanged);
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
            this.panelCosts.Controls.Add(this.textBoxTankkostenVerbrauch);
            this.panelCosts.Controls.Add(this.textBoxCostsKosten);
            this.panelCosts.Controls.Add(this.textBoxTankkostenLiter);
            this.panelCosts.Controls.Add(this.textBoxTankkostenKmGefahren);
            this.panelCosts.Controls.Add(this.comboBoxKategorie);
            this.panelCosts.Controls.Add(this.textBoxCostsBemerkung);
            this.panelCosts.Controls.Add(this.textBoxCostsKm);
            this.panelCosts.Location = new System.Drawing.Point(0, 0);
            this.panelCosts.Name = "panelCosts";
            this.panelCosts.Size = new System.Drawing.Size(937, 28);
            this.panelCosts.TabIndex = 13;
            // 
            // textBoxTankkostenVerbrauch
            // 
            this.textBoxTankkostenVerbrauch.Enabled = false;
            this.textBoxTankkostenVerbrauch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenVerbrauch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenVerbrauch.Location = new System.Drawing.Point(891, 3);
            this.textBoxTankkostenVerbrauch.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenVerbrauch.Name = "textBoxTankkostenVerbrauch";
            this.textBoxTankkostenVerbrauch.ReadOnly = true;
            this.textBoxTankkostenVerbrauch.Size = new System.Drawing.Size(43, 22);
            this.textBoxTankkostenVerbrauch.TabIndex = 19;
            this.textBoxTankkostenVerbrauch.Visible = false;
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
            this.textBoxTankkostenLiter.Visible = false;
            // 
            // textBoxTankkostenKmGefahren
            // 
            this.textBoxTankkostenKmGefahren.Enabled = false;
            this.textBoxTankkostenKmGefahren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankkostenKmGefahren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTankkostenKmGefahren.Location = new System.Drawing.Point(843, 3);
            this.textBoxTankkostenKmGefahren.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxTankkostenKmGefahren.Name = "textBoxTankkostenKmGefahren";
            this.textBoxTankkostenKmGefahren.ReadOnly = true;
            this.textBoxTankkostenKmGefahren.Size = new System.Drawing.Size(43, 22);
            this.textBoxTankkostenKmGefahren.TabIndex = 18;
            this.textBoxTankkostenKmGefahren.Visible = false;
            // 
            // UserControlCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCosts);
            this.Name = "UserControlCost";
            this.Size = new System.Drawing.Size(939, 29);
            this.panelCosts.ResumeLayout(false);
            this.panelCosts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCostsKosten;
        private System.Windows.Forms.TextBox textBoxCostsBemerkung;
        private System.Windows.Forms.TextBox textBoxCostsKm;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
		private System.Windows.Forms.DateTimePicker dateTimePickerCosts;
        private System.Windows.Forms.Panel panelCosts;
        private System.Windows.Forms.TextBox textBoxTankkostenVerbrauch;
        private System.Windows.Forms.TextBox textBoxTankkostenLiter;
        private System.Windows.Forms.TextBox textBoxTankkostenKmGefahren;
    }
}
