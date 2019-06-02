using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi
{
    public class Aiport
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public List<Destination> destinations { get; set; }

        public Aiport(string city, string name, string abbr, List<Destination> destinations)
        {
            City = city;
            Name = name;
            Abbr = abbr;
            this.destinations = destinations;
        }

        public void addDestination(Destination destination)
        {
            destinations.Add(destination);
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Abbr, Name, City);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Destination mostExpensiveDestination()
        {
            return destinations.Max();
        }

        public decimal averageLen()
        {
            decimal average = 0;
            foreach (Destination destination in destinations)
                average += destination.Distance;

            return Math.Round(average / destinations.Count,2);
        }
    }
}
