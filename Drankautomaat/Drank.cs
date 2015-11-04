namespace Drankautomaat
{
    public abstract class Drank : IVoorraad
    {
        public string Naam { get; set; }
        public int Voorraad { get; set; }
        public decimal Prijs { get; private set; }
        public int Milliliter { get; private set; }
        public bool WarmeDrank { get; private set; }

        public Drank (string naam, decimal prijs, int milliliter, bool warmeDrank)
        {
            Naam = naam;
            Prijs = prijs;
            Milliliter = milliliter;
            WarmeDrank = warmeDrank;
        }

        public override string ToString()
        {
            return "Drank: " + Naam +" Voorraad: " + Voorraad;
        }

    }
}