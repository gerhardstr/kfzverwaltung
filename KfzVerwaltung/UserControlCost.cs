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
				return this.cost;
			}
		}
	}
}
