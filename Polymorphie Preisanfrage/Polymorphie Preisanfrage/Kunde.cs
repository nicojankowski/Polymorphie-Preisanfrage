using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie_Preisanfrage
{
    class Kunde
    {
        string Name;
        string Vorname;
        string Adresse;

        public virtual void berechnePreisanfrage(double Preis)
        {
            double MWST = Preis * 0.19;
            double Endpreis = Preis + MWST;

            Console.WriteLine("\nIhre Preisanfrage für Artikel XY ergibt: {0} (inklusive MWST)", Endpreis);
           
        }
    }
}
