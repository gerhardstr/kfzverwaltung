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

        /*public UserControlCost(string mode)
        {
            InitializeComponent();
            this.panelCosts.Visible = false;
            this.panelFuelCosts.Visible = false;
            this.panelCosts.Location = new Point(3, 1);
            this.panelFuelCosts.Location = new Point(3, 1);

            switch (mode)
            {
                case "Costs":
                    this.panelCosts.Visible = true;
                    break;
                case "FuelCosts":
                    this.panelFuelCosts.Visible = true;
                    break;
                default:
                    break;
            }

        }*/

        public UserControlCost(Cost cost)
        {
            InitializeComponent();
            this.cost = cost;  
            this.comboBoxKategorie.Text = cost.Kategorie;
            this.dateTimePickerCosts.Text = cost.DatumKategorieXy.ToShortDateString();
            this.textBoxCostsBemerkung.Text = cost.Bemerkung;
            this.textBoxCostsKosten.Text = Convert.ToString(cost.Kosten);
            this.textBoxCostsKm.Text = Convert.ToString(cost.Kilometerstand);
            this.textBoxTankkostenLiter.Text = Convert.ToString(cost.Liter);
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
                    double tmp = 0;
                    if (double.TryParse(this.textBoxCostsKm.Text, out tmp)) this.cost.Kilometerstand = tmp;
                    if (double.TryParse(this.textBoxCostsKosten.Text, out tmp)) this.cost.Kosten = tmp;
                    this.cost.Bemerkung = this.textBoxCostsBemerkung.Text;
                }
                /*else if (!String.IsNullOrEmpty(this.textBoxTankkostenKosten.Text))
                {
                    if (this.cost == null) this.cost = new Cost();
                    this.cost.Kategorie = this.textBoxTankkostenKategorie.Text;
                    this.cost.DatumKategorieXy = DateTime.Parse(dateTimePickerTankkosten.Text);
                    double tmpE = 0;
                    if (double.TryParse(this.textBoxTankkostenKm.Text, out tmpE)) this.cost.Kilometerstand = tmpE;
                    if (double.TryParse(this.textBoxTankkostenKosten.Text, out tmpE)) this.cost.Kosten = tmpE;
                    if (double.TryParse(this.textBoxTankkostenLiter.Text, out tmpE)) this.cost.Liter = tmpE;
                    this.cost.Bemerkung = this.textBoxCostsBemerkung.Text;
                    this.cost.KilometerGefahren = Convert.ToDouble(this.textBoxTankkostenKm.Text) - this.cost.KilometerGefahren;
                }*/
                return this.cost;
            }

        }
    }

}

