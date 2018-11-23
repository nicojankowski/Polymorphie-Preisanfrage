using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie_Preisanfrage
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde[] Kundenarray = new Kunde[3];

            Kundenarray[0] = new Kunde();
            Kundenarray[1] = new Geschäftskunde();
            Kundenarray[2] = new Kunde();

            foreach (Kunde k in Kundenarray)
            {
                k.berechnePreisanfrage(299);
            }
            Console.ReadKey();
        }
    }
}
