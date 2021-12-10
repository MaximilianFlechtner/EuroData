using System;
using System.Collections.Generic;
using System.Text;

namespace EuroData
{
    public class Abteilung
    {
        public int ID { get; }
        public string Bezeichnung { get; set; }
        public double Etat { get; set; }
        public Abteilungsleiter AbteilungsLeiter { get; set; }
        public List<Mitarbeiter> Mitarbeiter { get; set; }

        public Abteilung(int abteilungsId, Abteilungsleiter leiter, Mitarbeiter mitarbeiter)
        {
            this.ID = abteilungsId;
            this.AbteilungsLeiter = leiter;

            Mitarbeiter = new List<Mitarbeiter>();
            Mitarbeiter.Add(mitarbeiter);
        }

        public void MitarbeiterHinzufügen(Mitarbeiter mitarbeiter)
        {
            this.Mitarbeiter.Add(mitarbeiter);
        }
    }
}
