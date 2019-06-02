using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi
{
    public class Destination:IComparable<Destination>
    {
        public string Name { get; set;}
        public decimal Distance { get; set; }
        public decimal Price { get; set; }

        public Destination(string name, decimal distance, decimal price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1} km - {2} EUR", Name, Distance, Price);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(Destination destination)
        {
            return (int)(Price - destination.Price);
        }
    }
}
