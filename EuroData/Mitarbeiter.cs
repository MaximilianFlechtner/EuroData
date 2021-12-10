using System;
using System.Collections.Generic;
using System.Text;

namespace EuroData
{
    public enum geschlecht
    {
        maennlich,weiblich,divers
    }
    public class Mitarbeiter
    {
        public int MitarbeiterNr { get; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public List<Kind> Kinder { get; set; }
        protected string strasse;
        protected int plz;
        protected string ort;
        protected string telefon;
        protected geschlecht geschlecht;
        protected DateTime einstellDatum;

        public Mitarbeiter(int mitarbeiterNr)
        {
            this.MitarbeiterNr = mitarbeiterNr;
            this.Kinder = new List<Kind>();
        }

        public void KindHinzufügen(Kind kind)
        {
            this.Kinder.Add(kind);
        }

        public void PKWBenennen(string pkw1, string pkw2)
        {
            
        }

        public void ZahltKindergartenplatz()
        {

        }

        public void ArbeitetAmProjekt(Projekt projekt)
        {

        }
    }
}
