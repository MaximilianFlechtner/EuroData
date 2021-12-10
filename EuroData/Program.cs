using System;
using System.Text;

namespace EuroData
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Abteilungsleiter leiter = new Abteilungsleiter(1)
            {
                Name = "Mustermann",
                Vorname = "Jonas"
            };

            Projektleiter projektleiter = new Projektleiter(2)
            {
                Name = "Mustermann",
                Vorname = "Stefan"
            };

            Mitarbeiter mitarbeiter = new Mitarbeiter(0)
            {
                Name = "Mustermann",
                Vorname = "Max"
            };

            Abteilung javaScriptAbteilung = new Abteilung(0, leiter, mitarbeiter)
            {
                Bezeichnung = "Java Script Entwicklung"
            };
          
            for(int i = 0; i < 6; ++i)
            {

                mitarbeiter.KindHinzufügen(new Kind()
                {
                    Vorname = "Unfall" + i 
                });

            }

            Projekt projekt = new Projekt(0);
            projekt.Leiter = projektleiter;

            Console.WriteLine("Die Abteilung " + javaScriptAbteilung.Bezeichnung + " hat folgende Mitarbeiter:");
            foreach(Mitarbeiter abteilungsArbeiter in javaScriptAbteilung.Mitarbeiter)
            {
                StringBuilder builder = new StringBuilder(abteilungsArbeiter.Vorname);

                builder.Append(' ').Append(abteilungsArbeiter.Name).Append(" mit den folgenden Kindern:");
                Console.WriteLine(builder.ToString());

                foreach(Kind abteilungsKind in abteilungsArbeiter.Kinder)
                {
                    Console.WriteLine(abteilungsKind.Vorname);
                }
                
            }
            
        }
    }
}
