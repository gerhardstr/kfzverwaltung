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
            this.comboBoxMarke.Text = car.Marke;
            this.textBoxModell.Text = car.Modell;
            this.textBoxKennzeichen.Text = car.KfzKennzeichen;
            this.dateTimePickerZulassung.Text = car.DatumZulassung.ToShortDateString();
            this.textBoxKW.Text = Convert.ToString(car.LeistungKW);
            this.textBoxPS.Text = Convert.ToString(car.LeistungPS);
            this.textBoxFarbe.Text = car.Farbe;
            this.textBoxFarbe.BackColor = ColorTranslator.FromHtml(car.FarbeBackground);
            this.textBoxWartungsintervall.Text = Convert.ToString(car.Wartungsintervall);

            GetLogo(this.comboBoxMarke.Text);

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

            if (dlgColor.ShowDialog() == DialogResult.OK) textBoxFarbe.BackColor = dlgColor.Color;
            textBoxFarbe.Text = (dlgColor.Color.ToArgb() & 0x00FFFFFF).ToString("X6"); // Alpha, red, green, blue; filter out Alpha (& 0x00FFFFFF); format as hex
        }

        private void buttonKfzOK_Click(object sender, EventArgs e)
        {
            if (this.car == null) this.car = new Car();

            if ((String.IsNullOrEmpty(this.comboBoxMarke.Text)) || (String.IsNullOrEmpty(this.textBoxModell.Text)) || (String.IsNullOrEmpty(this.textBoxKennzeichen.Text)))
            {
                if (String.IsNullOrEmpty(this.comboBoxMarke.Text)) this.comboBoxMarke.BackColor = Color.Red;
                if (String.IsNullOrEmpty(this.textBoxModell.Text)) this.textBoxModell.BackColor = Color.Red;
                if (String.IsNullOrEmpty(this.textBoxKennzeichen.Text)) this.textBoxKennzeichen.BackColor = Color.Red;
                MessageBox.Show("Die rot markierten Felder sind Pflichtfelder. Für die Anlage eines neuen Kfz füllen Sie diese bitte aus.", "Eingabeprüfung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.car.Marke = this.comboBoxMarke.Text;
                this.car.Modell = this.textBoxModell.Text;
                this.car.KfzKennzeichen = this.textBoxKennzeichen.Text;
                this.car.DatumZulassung = DateTime.Parse(dateTimePickerZulassung.Text);

                this.car.Costs = new List<Cost>(); // start CostCalculation
                foreach (UserControlCost uc in this.panelListCosts.Controls)
                    if (uc.Cost != null) this.car.Costs.Add(uc.Cost);
                this.car.Gesamtkosten = car.Costs.Sum(p => p.Kosten); // Costsummuary

                if (!String.IsNullOrEmpty(this.textBoxKW.Text) && IsNumeric(this.textBoxKW.Text)) this.car.LeistungKW = Convert.ToDouble(this.textBoxKW.Text);
                if (!String.IsNullOrEmpty(this.textBoxPS.Text)) this.car.LeistungPS = Convert.ToDouble(this.textBoxPS.Text);
                if (!String.IsNullOrEmpty(this.textBoxFarbe.Text))
                {
                    Color c = this.textBoxFarbe.BackColor;
                    string strColor = ColorTranslator.ToHtml(c);
                    this.car.Farbe = this.textBoxFarbe.Text;
                    this.car.FarbeBackground = strColor;
                }

                if (!String.IsNullOrEmpty(this.textBoxWartungsintervall.Text))
                {
                    if (IsNumeric(this.textBoxWartungsintervall.Text))
                    {
                        this.car.Wartungsintervall = Convert.ToDouble(this.textBoxWartungsintervall.Text);
                    }
                    else
                    {
                        return;
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonKfzCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAddUserControlCosts_Click(object sender, EventArgs e)
        {
            UserControlCost uc = new UserControlCost();
            this.panelListCosts.Controls.Add(uc);
        }

        private void pictureBoxKfzQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsNumeric(string text)
        {
            if (text.All(Char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{text} ist kein nummerischer Wert. Bitte geben sie eine Zahl ein.", "Eingabeprüfung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void GetLogo(string marke)
        {
            switch (marke)
            {
                case "Abarth":
                    this.pictureBoxLogo.Image = Properties.Resources.abarth;
                    break;

                case "Alfa Romeo":
                    this.pictureBoxLogo.Image = Properties.Resources.alfa_romeo;
                    break;

                case "Aston Martin":
                    this.pictureBoxLogo.Image = Properties.Resources.aston_martin;
                    break;

                case "Audi":
                    this.pictureBoxLogo.Image = Properties.Resources.audi;
                    break;

                case "Bugatti":
                    this.pictureBoxLogo.Image = Properties.Resources.bugatti;
                    break;

                case "Cadillac":
                    this.pictureBoxLogo.Image = Properties.Resources.cadillac;
                    break;

                case "Chevrolet":
                    this.pictureBoxLogo.Image = Properties.Resources.chevrolet;
                    break;

                case "Citroen":
                    this.pictureBoxLogo.Image = Properties.Resources.citroen;
                    break;

                case "Dacia":
                    this.pictureBoxLogo.Image = Properties.Resources.dacia;
                    break;

                case "Daewoo":
                    this.pictureBoxLogo.Image = Properties.Resources.daewoo;
                    break;

                case "Daihatsu":
                    this.pictureBoxLogo.Image = Properties.Resources.daihatsu;
                    break;

                case "Ferrari":
                    this.pictureBoxLogo.Image = Properties.Resources.ferrari;
                    break;

                case "Fiat":
                    this.pictureBoxLogo.Image = Properties.Resources.fiat;
                    break;

                case "Honda":
                    this.pictureBoxLogo.Image = Properties.Resources.honda;
                    break;

                case "Hyundai":
                    this.pictureBoxLogo.Image = Properties.Resources.hyundai;
                    break;

                case "Jaguar":
                    this.pictureBoxLogo.Image = Properties.Resources.jaguar;
                    break;

                case "Lamborghini":
                    this.pictureBoxLogo.Image = Properties.Resources.lamborghini;
                    break;

                case "Lancia":
                    this.pictureBoxLogo.Image = Properties.Resources.lancia;
                    break;

                case "Maserati":
                    this.pictureBoxLogo.Image = Properties.Resources.maserati;
                    break;

                case "Maybach":
                    this.pictureBoxLogo.Image = Properties.Resources.maybach;
                    break;

                case "Mazda":
                    this.pictureBoxLogo.Image = Properties.Resources.mazda;
                    break;

                case "Mercedes Benz":
                    this.pictureBoxLogo.Image = Properties.Resources.mercedes_benz;
                    break;

                case "Mini":
                    this.pictureBoxLogo.Image = Properties.Resources.mini;
                    break;

                case "Opel":
                    this.pictureBoxLogo.Image = Properties.Resources.opel;
                    break;

                case "Peugeot":
                    this.pictureBoxLogo.Image = Properties.Resources.peugeot;
                    break;

                case "Porsche":
                    this.pictureBoxLogo.Image = Properties.Resources.porsche;
                    break;

                case "Saab":
                    this.pictureBoxLogo.Image = Properties.Resources.saab;
                    break;

                case "Seat":
                    this.pictureBoxLogo.Image = Properties.Resources.seat;
                    break;

                case "Skoda":
                    this.pictureBoxLogo.Image = Properties.Resources.skoda;
                    break;

                case "Volvo":
                    this.pictureBoxLogo.Image = Properties.Resources.volvo;
                    break;

                case "Volkswagen":
                    this.pictureBoxLogo.Image = Properties.Resources.vw;
                    break;

                default:
                    this.pictureBoxLogo.Image = Properties.Resources.logo_auto_single_dark;
                    break;
            }
        }

        private void textBoxKW_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxKW.Text) && IsNumeric(this.textBoxKW.Text))
                this.textBoxPS.Text = (int.Parse(this.textBoxKW.Text) * 1.35962).ToString("0.##");
        }

        private void comboBoxMarke_TextChanged(object sender, EventArgs e)
        {
            GetLogo(this.comboBoxMarke.Text);
        }
    }
}
