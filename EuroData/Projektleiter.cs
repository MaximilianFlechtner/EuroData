using System;
using System.Collections.Generic;
using System.Text;

namespace EuroData
{
    public class Projektleiter: Mitarbeiter
    {
        public int ProjNr { get; set; }
        public int Zeitanteil { get; set; }

        public Projektleiter(int mitarbeiterNr) : base(mitarbeiterNr)
        {

        }

        public void ProjektdatenEinsehen()
        {

        }

        public void ProjektdatenÄndern()
        {

        }
    }
}
