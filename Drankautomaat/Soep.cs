using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    public class Soep : Drank
    {
        public Soep(string naam, decimal prijs, int milliliter)
            : base(naam, prijs, milliliter, true)
        { }

        public override string ToString()
        {
            return "Soep: " + Naam + " (\u20AC" + Prijs + ",00) Voorraad: " + Voorraad;
        }

    }
}
