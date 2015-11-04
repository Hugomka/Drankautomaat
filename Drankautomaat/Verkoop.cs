using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    public class Verkoop : IComparable
    {
        public DateTime Tijdstip { get; set; }
        public Drank Drank { get; set; }
        
        public Verkoop(Drank drank)
        {
            Tijdstip = DateTime.Now;
            Drank = drank;
        }

        public int CompareTo(object obj)
        {
            return Tijdstip.CompareTo(obj);
        }

        public override string ToString()
        {
            return Tijdstip.ToString() + " - " + Drank.Naam;
        }
    }
}
