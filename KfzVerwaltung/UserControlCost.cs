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
            this.textBoxCostsBemerkung.AutoSize = false; // weird stuff for deactivate autosize
            this.textBoxCostsBemerkung.Text = cost.Bemerkung;
            this.textBoxCostsKosten.AutoSize = false;
            this.textBoxCostsKosten.Text = Convert.ToString(cost.Kosten);
            this.textBoxCostsKm.AutoSize = false;
            this.textBoxCostsKm.Text = Convert.ToString(cost.Kilometerstand);
            
            if (this.comboBoxKategorie.Text == "Tankkosten")
            {
                this.pictureBoxLiter.Visible = true;
                this.textBoxTankkostenLiter.Visible = true;
                this.textBoxTankkostenLiter.AutoSize = false;
                this.textBoxTankkostenLiter.Text = Convert.ToString(cost.Liter);
                this.textBoxTankkostenKmGefahren.AutoSize = false;
                this.textBoxTankkostenKmGefahren.Visible = true;
                this.textBoxTankkostenKmGefahren.Text = Convert.ToString(cost.KilometerGefahren);
                this.textBoxTankkostenVerbrauch.AutoSize = false;
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

                    if (this.comboBoxKategorie.Text == "Tankkosten")
                    {
                        double tmpD = 0;
                        if (double.TryParse(this.textBoxTankkostenLiter.Text, out tmpD)) this.cost.Liter = tmpD;
                        if (double.TryParse(this.textBoxCostsKm.Text, out tmpD)) this.cost.KilometerGefahren = tmpD - this.cost.KilometerGefahren;
                        this.cost.Verbrauch = (this.cost.Liter / this.cost.KilometerGefahren) * 100;
                    }
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

