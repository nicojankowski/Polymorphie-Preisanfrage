using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie_Preisanfrage
{
    class Geschäftskunde : Kunde
    {
        double Rabattsatz = 0.03;



        public override void berechnePreisanfrage(double Preis)
        {
            double MWST = Preis * 0.19;
            double Endpreis = Preis * (1 - Rabattsatz);
            Console.WriteLine("\nIhre Preisanfrage für Artikel XY ergibt: {0} (+{1})", Endpreis, MWST);
        }
    }
}
