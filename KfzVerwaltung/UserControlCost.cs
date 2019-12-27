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
using System.Globalization;

namespace KfzVerwaltung
{
    public partial class UserControlCost : UserControl
    {
        private Cost cost = null;

        public UserControlCost()
        {
            InitializeComponent();
        }

        public UserControlCost(Cost cost)
        {
            InitializeComponent();
            this.cost = cost;  
            this.comboBoxKategorie.Text = cost.Kategorie;
            this.dateTimePickerCosts.Text = cost.DatumKategorieXy.ToShortDateString();
            this.textBoxCostsBemerkung.Text = cost.Bemerkung;
            this.textBoxCostsKosten.Text = Convert.ToString(cost.Kosten);
            this.textBoxCostsKm.Text = Convert.ToString(cost.Kilometerstand);
            
            if (this.comboBoxKategorie.Text == "Tankkosten")
            {
                this.textBoxTankkostenLiter.Visible = true;
                this.textBoxTankkostenLiter.Text = Convert.ToString(cost.Liter);
                this.textBoxTankkostenKmGefahren.Visible = true;
                this.textBoxTankkostenKmGefahren.Text = Convert.ToString(cost.KilometerGefahren);
                this.textBoxTankkostenVerbrauch.Visible = true;
                this.textBoxTankkostenVerbrauch.Text = Convert.ToString(cost.Verbrauch);
            }
        }

        public Cost Cost
        {
            get
            {
                if (!String.IsNullOrEmpty(this.comboBoxKategorie.Text))
                {
                    if (this.cost == null) this.cost = new Cost();
                    this.cost.Kategorie = this.comboBoxKategorie.Text;
                    this.cost.DatumKategorieXy = DateTime.Parse(dateTimePickerCosts.Text);
                    this.cost.Bemerkung = this.textBoxCostsBemerkung.Text;

                    double tmp = 0;
                    if (double.TryParse(this.textBoxCostsKm.Text, out tmp)) this.cost.Kilometerstand = tmp;
                    if (double.TryParse(this.textBoxCostsKosten.Text, out tmp)) this.cost.Kosten = tmp;
                    if (double.TryParse(this.textBoxTankkostenLiter.Text, out tmp)) this.cost.Liter = tmp;
                    if (double.TryParse(this.textBoxTankkostenKmGefahren.Text, out tmp)) this.cost.KilometerGefahren = tmp;

                    int tmpI = 0;
                    if (int.TryParse(this.textBoxTankkostenVerbrauch.Text, out tmpI)) this.cost.Verbrauch = tmpI;
                }
                return this.cost;
            }

        }

        private void comboBoxKategorie_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBoxKategorie.Text == "Tankkosten")
            {
                this.textBoxTankkostenLiter.Visible = true;
                this.textBoxTankkostenKmGefahren.Visible = true;
                this.textBoxTankkostenVerbrauch.Visible = true;
            }
        }
    }

}

