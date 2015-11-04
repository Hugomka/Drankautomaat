using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    public class Verkoop : IComparable<Verkoop>
    {
        public DateTime Tijdstip { get; set; }
        public Drank Drank { get; set; }
        
        public Verkoop(Drank drank)
        {
            Tijdstip = DateTime.Now;
            Drank = drank;
        }
        /// <summary>
        /// Sorteermethode op tijdstip
        /// </summary>
        /// <param name="andere">Andere verkoopregel in de lijst</param>
        /// <returns></returns>
        public int CompareTo(Verkoop andere)
        {
            return andere.Tijdstip.CompareTo(Tijdstip);
        }

        public override string ToString()
        {
            return Tijdstip.ToString() + " - " + Drank.Naam;
        }
    }
}
