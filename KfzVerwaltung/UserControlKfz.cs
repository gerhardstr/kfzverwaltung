using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KfzVerwaltung.Data;

namespace KfzVerwaltung
{
    public partial class UserControlKfz : UserControl
    {
        public Cars Cars { get; set; } = null;
        public UserControlKfz()
        {
            InitializeComponent();
        }

        public UserControlKfz(Cars car)
        {
            InitializeComponent();
            this.Cars = car;
            this.labelMarke.Text = car.Marke;
            this.labelModell.Text = car.Modell;
            this.labelKennzeichen.Text = car.KfzKennzeichen;
            this.labelDatumZulassung.Text = car.DatumZulassung.ToShortDateString();
            this.labelGesamtkosten.Text = Convert.ToString(car.Gesamtkosten);
        }

        private void UserControlKfz_MouseDoubleClick(object sender, EventArgs e)
        {
            FormKfz kfzForm = new FormKfz(this.Cars);
            if (kfzForm.ShowDialog() == DialogResult.OK)
            {
                this.labelMarke.Text = this.Cars.Marke;
                this.labelModell.Text = this.Cars.Modell;
                this.labelKennzeichen.Text = this.Cars.KfzKennzeichen;
                this.labelDatumZulassung.Text = this.Cars.DatumZulassung.ToShortDateString();
                this.labelGesamtkosten.Text = Convert.ToString(this.Cars.Gesamtkosten);
            }

        }

        private void pictureBoxKfzDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten sie diesen Eintrag wirklich löschen?", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
