using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KfzVerwaltung.Data
{
	[Serializable()]
	public class Cost
	{
		public string Kategorie { get; set; }
		public DateTime DatumKategorieXy { get; set; } = DateTime.Now;
		public string Bemerkung { get; set; }
		public double Kosten { get; set; } 
		public double Liter { get; set; } 
		public double Kilometerstand { get; set; }
        public double KilometerGefahren { get; set; }
        public double Verbrauch { get; set; }
    }
}
