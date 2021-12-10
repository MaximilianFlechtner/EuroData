using System;
using System.Collections.Generic;
using System.Text;

namespace EuroData
{
    public class Kind
    {
        public string Vorname { get; set; }
        public DateTime GebDatum { get; set; }

        private List<Mitarbeiter> eltern;
        public List<Mitarbeiter> Eltern
        {
            get
            {
                return eltern;
            }
            set
            {
                if(value.Count > 2)
                {
                    return;
                }

                eltern = value;
            }
        }

        public Kind()
        {
            this.Eltern = new List<Mitarbeiter>();
        }

        public void BesuchtBetriebskindergarten()
        {

        }

    }
}
