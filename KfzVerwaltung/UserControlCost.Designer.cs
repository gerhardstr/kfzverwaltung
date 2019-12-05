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
			this.SuspendLayout();
			// 
			// textBoxCostsKosten
			// 
			this.textBoxCostsKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCostsKosten.Location = new System.Drawing.Point(247, 2);
			this.textBoxCostsKosten.MinimumSize = new System.Drawing.Size(4, 24);
			this.textBoxCostsKosten.Name = "textBoxCostsKosten";
			this.textBoxCostsKosten.Size = new System.Drawing.Size(83, 22);
			this.textBoxCostsKosten.TabIndex = 10;
			// 
			// textBoxCostsBemerkung
			// 
			this.textBoxCostsBemerkung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCostsBemerkung.Location = new System.Drawing.Point(450, 2);
			this.textBoxCostsBemerkung.MinimumSize = new System.Drawing.Size(4, 24);
			this.textBoxCostsBemerkung.Name = "textBoxCostsBemerkung";
			this.textBoxCostsBemerkung.Size = new System.Drawing.Size(225, 22);
			this.textBoxCostsBemerkung.TabIndex = 12;
			// 
			// textBoxCostsKm
			// 
			this.textBoxCostsKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCostsKm.Location = new System.Drawing.Point(336, 2);
			this.textBoxCostsKm.MinimumSize = new System.Drawing.Size(4, 24);
			this.textBoxCostsKm.Name = "textBoxCostsKm";
			this.textBoxCostsKm.Size = new System.Drawing.Size(108, 22);
			this.textBoxCostsKm.TabIndex = 11;
			// 
			// comboBoxKategorie
			// 
			this.comboBoxKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxKategorie.FormattingEnabled = true;
			this.comboBoxKategorie.Items.AddRange(new object[] {
            "Versicherungskosten",
            "Leasing Rate",
            "Tankkosten",
            "Reifenwechsel",
            "Service",
            "Sonstige Kosten"});
			this.comboBoxKategorie.Location = new System.Drawing.Point(3, 2);
			this.comboBoxKategorie.Name = "comboBoxKategorie";
			this.comboBoxKategorie.Size = new System.Drawing.Size(141, 24);
			this.comboBoxKategorie.TabIndex = 8;
			// 
			// dateTimePickerCosts
			// 
			this.dateTimePickerCosts.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerCosts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerCosts.Location = new System.Drawing.Point(150, 2);
			this.dateTimePickerCosts.Name = "dateTimePickerCosts";
			this.dateTimePickerCosts.Size = new System.Drawing.Size(91, 22);
			this.dateTimePickerCosts.TabIndex = 9;
			// 
			// UserControlCosts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateTimePickerCosts);
			this.Controls.Add(this.comboBoxKategorie);
			this.Controls.Add(this.textBoxCostsKm);
			this.Controls.Add(this.textBoxCostsBemerkung);
			this.Controls.Add(this.textBoxCostsKosten);
			this.Name = "UserControlCosts";
			this.Size = new System.Drawing.Size(680, 28);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCostsKosten;
        private System.Windows.Forms.TextBox textBoxCostsBemerkung;
        private System.Windows.Forms.TextBox textBoxCostsKm;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
		private System.Windows.Forms.DateTimePicker dateTimePickerCosts;
	}
}
