using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    public class Voorraad
    {
        private List<IVoorraad> beschikbareProducten = new List<IVoorraad>();
        private List<Verkoop> verkochteProducten = new List<Verkoop>();
        public bool NieuwProduct(Drank drank)
        {
            if (!beschikbareProducten.Contains(drank))
            {
                beschikbareProducten.Add(drank);
                return true;
            }
            return false;
        }

        public bool NieuwProduct(Beker beker)
        {
            if (!beschikbareProducten.Contains(beker))
            {
                beschikbareProducten.Add(beker);
                return true;
            }
            return false;
        }

        public void VerkochteProduct(Drank drank)
        {
            // Toevogen bij de verkooplijst
            verkochteProducten.Add(new Verkoop(drank));
            // Sorteren op tijdstip van hoog naar laag
            verkochteProducten.Sort();
        }

        public List<IVoorraad> BeschikbareProducten()
        {
            return beschikbareProducten;
        }

        public List<Verkoop> VerkochteProducten()
        {
            return verkochteProducten;
        }

        public void VulBij(IVoorraad product, int aantal)
        {
            beschikbareProducten[beschikbareProducten.IndexOf(product)].Voorraad += aantal;
        }

        public bool KoopDrank(Drank drank, decimal inworp)
        {
            Drank d = (Drank)beschikbareProducten[beschikbareProducten.IndexOf(drank)];
            Beker b = null;
            //De inworp dient tenminste gelijk te zijn aan de prijs van de drank
            if (inworp == d.Prijs)
            {
                bool succes = false;
                foreach (var product in beschikbareProducten)
                {
                    //Product is een beker, geen drank.
                    if (product is Beker)
                    {
                        b = (Beker)product;
                        //Er moet een beker op voorraad zijn
                        if (b.Voorraad > 0
                            //Deze beker moet geschikt zijn voor de soort drank (warm/koud);
                            && b.WarmeDrankMogelijk == d.WarmeDrank
                            //De inhoud van de beker moet groot genoeg zijn om de drank te kunnen bevatten;
                            && b.Milliliter >= d.Milliliter + 20)
                        {
                            d.Voorraad--;
                            b.Voorraad--;
                            succes = true;
                            return true;
                        }
                    }
                }
                // throw exception als de lus geen succes is.
                if (!succes)
                {
                    if (b == null || b.Voorraad <= 0)
                        throw new OnvoldoendeBekersException("Onvoldoende bekers in voorraad.");
                    else if (b.WarmeDrankMogelijk != d.WarmeDrank && b.WarmeDrankMogelijk == true)
                        throw new OnvoldoendeBekersException("Onvoldoende warme bekers.");
                    else if (b.WarmeDrankMogelijk != d.WarmeDrank && b.WarmeDrankMogelijk == false)
                        throw new OnvoldoendeBekersException("Onvoldoende koude bekers.");
                    else if (b.Milliliter >= d.Milliliter)
                        throw new OnvoldoendeBekersException("Onvoldoende bekers met juiste capaciteit./r/n" +
                                "De capaciteit van beker moet 20 ml groter dan drankhoeveelheid.");
                }
            }
            else
            {
                throw new Exception("Incorrecte inworpen, graag exacte bedrag invoeren.");
            }

            return false;
        }

        public override string ToString()
        {
            return "Voorraad: ";
        }
    }
}

