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
    public partial class UserControlCosts : UserControl
    {
        private Cars cars = null;
        CultureInfo deCulture = new System.Globalization.CultureInfo("de-DE");

        public UserControlCosts()
        {
            InitializeComponent();
        }

        public UserControlCosts(Cars cars)
        {
            InitializeComponent();
            this.cars = cars;
            this.comboBoxKategorie.SelectedItem = cars.Kategorie;
            this.dateTimePickerCosts.Text = cars.DatumKategorieXy.ToShortDateString();
            this.textBoxCostsBemerkung.Text = cars.Bemerkung;
            this.textBoxCostsKosten.Text = Convert.ToString(cars.Kosten);
            this.textBoxCostsKm.Text = Convert.ToString(cars.Kilometerstand);
        }

        public Cars Cars
        {
            get
            {
                if (this.comboBoxKategorie.SelectedItem != null)
                {
                    if (this.cars == null) this.cars = new Cars();
                    this.cars.Kategorie = this.comboBoxKategorie.SelectedItem.ToString();
                    this.cars.DatumKategorieXy = DateTime.Parse(dateTimePickerCosts.Text);
                    if (!double.TryParse(this.textBoxCostsKm.Text, out double b))
                        MessageBox.Show($"Der Wert >{this.textBoxCostsKm.Text}< ist keine Zahl. Bitte korrigieren.");
                    else
                        this.cars.Kilometerstand = double.Parse(textBoxCostsKm.Text);
                    if (!double.TryParse(this.textBoxCostsKosten.Text, out double c))
                        MessageBox.Show($"Der Wert >{this.textBoxCostsKosten.Text}< ist keine Zahl. Bitte korrigieren.");
                    else
                        this.cars.Kosten = double.Parse(textBoxCostsKosten.Text);

                    this.cars.Bemerkung = this.textBoxCostsBemerkung.Text;

                }
                return this.cars;
            }
        }

        public List<UserControlCosts> CostList { get; set; } = new List<UserControlCosts>();
    }
}
