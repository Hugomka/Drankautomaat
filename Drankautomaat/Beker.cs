using System;

namespace Drankautomaat
{
    public class Beker : IVoorraad
    {
        public int Milliliter { get; private set; }
        public bool WarmeDrankMogelijk { get; private set; }

        public string Naam { get; set; }
        public int Voorraad { get; set; }

        public Beker(string naam, int milliliter, bool warmeDrankMogelijk)
        {
            Naam = naam;
            Milliliter = milliliter;
            WarmeDrankMogelijk = warmeDrankMogelijk;
        }

        public override string ToString()
        {
            return "Beker: " + Naam + " Voorraad: " + Voorraad;
        }

    }
}