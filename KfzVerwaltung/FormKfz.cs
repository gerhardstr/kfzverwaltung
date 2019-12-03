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
        private Cars cars = null;

        public Cars Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public FormKfz()
        {
            InitializeComponent();
        }

        public FormKfz(Cars cars)
        {
            InitializeComponent();
            this.cars = cars;
            this.textBoxMarke.Text = cars.Marke;
            this.textBoxModell.Text = cars.Modell;
            this.textBoxKennzeichen.Text = cars.KfzKennzeichen;
            this.dateTimePickerZulassung.Text = cars.DatumZulassung.ToShortDateString();
            this.textBoxKW.Text = Convert.ToString(cars.LeistungKW);
            this.textBoxPS.Text = Convert.ToString(cars.LeistungPS);
            this.textBoxFarbe.Text = cars.Farbe;
            //this.textBoxFarbe.BackColor = cars.Farbe; // todo
            this.textBoxWartungsintervall.Text = Convert.ToString(cars.Wartungsintervall);

            UserControlCosts uc = null;
            foreach (Cars cart in cars.CarList)
            {
                uc = new UserControlCosts(cart);
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
            if (this.cars == null) this.cars = new Cars();
            this.cars.Marke = this.textBoxMarke.Text;
            this.cars.Modell = this.textBoxModell.Text;
            this.cars.KfzKennzeichen = this.textBoxKennzeichen.Text;
            if (!DateTime.TryParse(dateTimePickerZulassung.Text, out DateTime d)) // start parsing action
                MessageBox.Show($"Der Wert >{this.dateTimePickerZulassung.Text}< ist kein Datum. Bitte korrigieren.");
            else
                this.cars.DatumZulassung = DateTime.Parse(dateTimePickerZulassung.Text);

            double total = 0;
            foreach (Cars cart in cars.CarList)
            {
                total = total + cart.Kosten;  // sum all costs
            }

            this.cars.Gesamtkosten = total;
            this.cars.LeistungKW = Convert.ToDouble(this.textBoxKW.Text);
            this.cars.Farbe = this.textBoxFarbe.Text;
					
            this.cars.Wartungsintervall = Convert.ToDouble(this.textBoxWartungsintervall.Text);

            this.cars.CarList = new List<Cars>();
            foreach (UserControlCosts uc in this.panelListCosts.Controls)
                if (uc.Cars != null) this.cars.CarList.Add(uc.Cars);

            this.DialogResult = DialogResult.OK;
            this.Close();
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
            UserControlCosts uc = new UserControlCosts();
            this.panelListCosts.Controls.Add(uc);
        }
	}
}
