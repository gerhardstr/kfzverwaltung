using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KfzVerwaltung.Data;

namespace KfzVerwaltung
{
	public partial class FormKfz : Form
	{
		private Car car = null;

		public Car Car
		{
			get { return car; }
			set { car = value; }
		}

		public FormKfz()
		{
			InitializeComponent();
		}

		public FormKfz(Car car)
		{
			InitializeComponent();
			this.car = car;
			this.textBoxMarke.Text = car.Marke;
			this.textBoxModell.Text = car.Modell;
			this.textBoxKennzeichen.Text = car.KfzKennzeichen;
			this.dateTimePickerZulassung.Text = car.DatumZulassung.ToShortDateString();
			this.textBoxKW.Text = Convert.ToString(car.LeistungKW);
			this.textBoxPS.Text = Convert.ToString(car.LeistungPS);
			this.textBoxFarbe.Text = car.Farbe;
			this.textBoxFarbe.BackColor = ColorTranslator.FromHtml(car.FarbeBackground); 
			this.textBoxWartungsintervall.Text = Convert.ToString(car.Wartungsintervall);

			UserControlCost uc = null;
			foreach (Cost cost in car.Costs)
			{
				uc = new UserControlCost(cost);
				this.panelListCosts.Controls.Add(uc);
			}
		}

		private void buttonKfzColor_Click(object sender, EventArgs e)
		{
			ColorDialog dlgColor = new ColorDialog();
			dlgColor.AllowFullOpen = false; // user is not allowed to pick custom color
			dlgColor.Color = textBoxFarbe.ForeColor;

			if (dlgColor.ShowDialog() == DialogResult.OK)
				textBoxFarbe.BackColor = dlgColor.Color;
			textBoxFarbe.Text = (dlgColor.Color.ToArgb() & 0x00FFFFFF).ToString("X6"); // Alpha, red, green, blue; filter out Alpha (& 0x00FFFFFF); format as hex
		}

		private void buttonKfzOK_Click(object sender, EventArgs e)
		{
			if (this.car == null) this.car = new Car();
			if ((String.IsNullOrEmpty(this.textBoxMarke.Text)) || (String.IsNullOrEmpty(this.textBoxModell.Text)) || (String.IsNullOrEmpty(this.textBoxKennzeichen.Text)))
			{
				if (String.IsNullOrEmpty(this.textBoxMarke.Text)) this.textBoxMarke.BackColor = Color.Red;
				if (String.IsNullOrEmpty(this.textBoxModell.Text)) this.textBoxModell.BackColor = Color.Red;
				if (String.IsNullOrEmpty(this.textBoxKennzeichen.Text)) this.textBoxKennzeichen.BackColor = Color.Red;
				MessageBox.Show("Die rot markierten Felder sind Pflichtfelder. Für die Anlage eines neuen Kfz füllen Sie diese bitte aus.", "Validierung", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				this.car.Marke = this.textBoxMarke.Text;
				this.car.Modell = this.textBoxModell.Text;
				this.car.KfzKennzeichen = this.textBoxKennzeichen.Text;
				this.car.DatumZulassung = DateTime.Parse(dateTimePickerZulassung.Text);
                
                this.car.Costs = new List<Cost>(); // start CostCalculation
                foreach (UserControlCost uc in this.panelListCosts.Controls)
                    if (uc.Cost != null) this.car.Costs.Add(uc.Cost);
                this.car.Gesamtkosten = car.Costs.Sum(p => p.Kosten); // Costsummuary

				if (!String.IsNullOrEmpty(this.textBoxKW.Text)) this.car.LeistungKW = Convert.ToDouble(this.textBoxKW.Text);
				if (!String.IsNullOrEmpty(this.textBoxPS.Text)) this.car.LeistungPS = Convert.ToDouble(this.textBoxPS.Text);
				if (!String.IsNullOrEmpty(this.textBoxFarbe.Text))
				{
					Color c = this.textBoxFarbe.BackColor;
					string strColor = ColorTranslator.ToHtml(c);
					this.car.Farbe = this.textBoxFarbe.Text;
					this.car.FarbeBackground = strColor;
				}
		 
				if (!String.IsNullOrEmpty(this.textBoxWartungsintervall.Text)) this.car.Wartungsintervall = Convert.ToDouble(this.textBoxWartungsintervall.Text);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void buttonKfzCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void textBoxKW_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.textBoxKW.Text))
				this.textBoxPS.Text = (int.Parse(this.textBoxKW.Text) * 1.35962).ToString();
		}

		private void buttonAddUserControlCosts_Click(object sender, EventArgs e)
		{
			UserControlCost uc = new UserControlCost();
			this.panelListCosts.Controls.Add(uc);
		}

        /*private void buttonAddUserControlTankkosten_Click(object sender, EventArgs e)
        {
            UserControlCost uc = new UserControlCost("FuelCosts");
            this.panelListCosts.Controls.Add(uc);
        }*/
    }
}
