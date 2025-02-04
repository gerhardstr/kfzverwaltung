﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KfzVerwaltung.Data
{
    [Serializable()]
    public class Car
    {
        #region properties
        public string Marke { get; set; }
        public string Modell { get; set; }
        public string KfzKennzeichen { get; set; }
        public DateTime DatumZulassung { get; set; } = DateTime.Now;
        public double Gesamtkosten { get; set; }
        public string Farbe { get; set; }
        public string FarbeBackground { get; set; }
        public double LeistungKW { get; set; }
        public double LeistungPS { get; set; }
        public double Wartungsintervall { get; set; }
        public List<Cost> Costs { get; set; } = new List<Cost>();
        #endregion
    }
}
