using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KfzVerwaltung.Data
{
    public class Cars
    {
        private int leistung = 0;

        #region properties
        public string Marke { get; set; } = string.Empty;
        public string Modell { get; set; } = string.Empty;
        public string KfzKennzeichen { get; set; } = string.Empty;
        public DateTime DatumZulassung { get; set; } = DateTime.Now;
        public double Gesamtkosten { get; set; } // todo
        public string Farbe { get; set; } = string.Empty;
        public int LeistungKW { get; set; } = 0;
        public int LeistungPS
        {
            get
            {
                double temp = (double)this.LeistungKW * 1.35962;
                return (int)temp;
            }
            set
            {
                this.leistung = value;
            }
        }
        public double Wartungsintervall { get; set; } = 0;
        public string Kategorie { get; set; } = string.Empty;
        public DateTime DatumKategorieXy { get; set; } = DateTime.Now;
        public string Bemerkung { get; set; }
        public double Kosten { get; set; } = 0;
        public double Liter { get; set; } = 0;
        public double Kilometerstand { get; set; } = 0;
        public List<Cars> CarList { get; set; } = new List<Cars>();
        
        #endregion
    }
}
