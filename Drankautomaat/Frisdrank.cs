using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    public class Frisdrank : Drank
    {
        public int GramSuiker { get; private set; }

        public Frisdrank(string naam, decimal prijs, int milliliter, int gramSuiker)
            : base(naam, prijs, milliliter, false)
        {
            GramSuiker = gramSuiker;
        }

        public override string ToString()
        {
            return "Frisdrank: " + Naam + " (\u20AC" + Prijs + ",00) Voorraad: " + Voorraad;
        }
    }
}
