using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    public class Koffie : Drank
    {
        public int MilligramCafeine { get; private set; }

        public Koffie(string naam, decimal prijs, int milliliter, int milligramCafeine)
            : base (naam, prijs, milliliter, true)
        {
            MilligramCafeine = milligramCafeine;
        }

        public override string ToString()
        {
            return "Koffie: " + Naam + " (\u20AC" + Prijs + ") Voorraad: " + Voorraad;
        }
    }
}
