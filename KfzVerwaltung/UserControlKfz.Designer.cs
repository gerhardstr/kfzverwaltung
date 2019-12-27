namespace KfzVerwaltung
{
    partial class UserControlKfz
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
            this.labelMarke = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.labelDatumZulassung = new System.Windows.Forms.Label();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelGesamtkosten = new System.Windows.Forms.Label();
            this.pictureBoxKfzDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKfzDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMarke
            // 
            this.labelMarke.AutoEllipsis = true;
            this.labelMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarke.Location = new System.Drawing.Point(4, 4);
            this.labelMarke.Name = "labelMarke";
            this.labelMarke.Size = new System.Drawing.Size(100, 16);
            this.labelMarke.TabIndex = 0;
            this.labelMarke.Text = "Marke";
            this.labelMarke.DoubleClick += new System.EventHandler(this.UserControlKfz_MouseDoubleClick);
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKennzeichen.Location = new System.Drawing.Point(235, 4);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(104, 16);
            this.labelKennzeichen.TabIndex = 1;
            this.labelKennzeichen.Text = "Kfz Kennzeichen";
            this.labelKennzeichen.DoubleClick += new System.EventHandler(this.UserControlKfz_MouseDoubleClick);
            // 
            // labelDatumZulassung
            // 
            this.labelDatumZulassung.AutoSize = true;
            this.labelDatumZulassung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumZulassung.Location = new System.Drawing.Point(375, 4);
            this.labelDatumZulassung.Name = "labelDatumZulassung";
            this.labelDatumZulassung.Size = new System.Drawing.Size(151, 16);
            this.labelDatumZulassung.TabIndex = 2;
            this.labelDatumZulassung.Text = "Datum erstm. Zulassung";
            this.labelDatumZulassung.DoubleClick += new System.EventHandler(this.UserControlKfz_MouseDoubleClick);
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModell.Location = new System.Drawing.Point(130, 4);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(49, 16);
            this.labelModell.TabIndex = 3;
            this.labelModell.Text = "Modell";
            this.labelModell.DoubleClick += new System.EventHandler(this.UserControlKfz_MouseDoubleClick);
            // 
            // labelGesamtkosten
            // 
            this.labelGesamtkosten.AutoSize = true;
            this.labelGesamtkosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGesamtkosten.Location = new System.Drawing.Point(525, 4);
            this.labelGesamtkosten.Name = "labelGesamtkosten";
            this.labelGesamtkosten.Size = new System.Drawing.Size(95, 16);
            this.labelGesamtkosten.TabIndex = 4;
            this.labelGesamtkosten.Text = "Gesamtkosten";
            this.labelGesamtkosten.DoubleClick += new System.EventHandler(this.UserControlKfz_MouseDoubleClick);
            // 
            // pictureBoxKfzDelete
            // 
            this.pictureBoxKfzDelete.Image = global::KfzVerwaltung.Properties.Resources.DeleteListItem_16x;
            this.pictureBoxKfzDelete.Location = new System.Drawing.Point(736, 2);
            this.pictureBoxKfzDelete.Name = "pictureBoxKfzDelete";
            this.pictureBoxKfzDelete.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxKfzDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxKfzDelete.TabIndex = 6;
            this.pictureBoxKfzDelete.TabStop = false;
            this.pictureBoxKfzDelete.Click += new System.EventHandler(this.pictureBoxKfzDelete_Click);
            // 
            // UserControlKfz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pictureBoxKfzDelete);
            this.Controls.Add(this.labelGesamtkosten);
            this.Controls.Add(this.labelModell);
            this.Controls.Add(this.labelDatumZulassung);
            this.Controls.Add(this.labelKennzeichen);
            this.Controls.Add(this.labelMarke);
            this.Name = "UserControlKfz";
            this.Size = new System.Drawing.Size(780, 21);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserControlKfz_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKfzDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.Label labelDatumZulassung;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Label labelGesamtkosten;
        private System.Windows.Forms.PictureBox pictureBoxKfzDelete;
    }
}
