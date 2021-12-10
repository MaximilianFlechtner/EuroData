using System;
using System.Collections.Generic;
using System.Text;

namespace EuroData
{
    public class Projekt
    {
        public int ProjNr { get; }
        public string Bezeichnung { get; set; }
        public double Auftragswert { get; set; }
        public double Bezahlt { get; set; }
        public DateTime Beginn { get; set; }
        public DateTime Ende { get; set; }
        public int Storno { get; set; }
        public Projektleiter Leiter { get; set; }

        public Projekt(int projNr)
        {
            this.ProjNr = projNr;
        }
    }
}
