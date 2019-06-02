using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Car : IEquatable<Car>
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Potroshuvacka { get; set; }
        public decimal Cena { get; set; }

        public Car(string marka, string model, decimal potroshuvacka, decimal cena)
        {
            Marka = marka;
            Model = model;
            Potroshuvacka = potroshuvacka;
            Cena = cena;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Car);
        }

        public bool Equals(Car other)
        {
            return other != null &&
                   Marka == other.Marka &&
                   Model == other.Model &&
                   Potroshuvacka == other.Potroshuvacka &&
                   Cena == other.Cena;
        }

        public override string ToString()
        {
            return String.Format("{0}, model {1} , cena {2} , potroshuvacka {3} \n", Marka, Model, Cena, Potroshuvacka);
        }

        public override int GetHashCode()
        {
            var hashCode = -271429408;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Marka);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + Potroshuvacka.GetHashCode();
            hashCode = hashCode * -1521134295 + Cena.GetHashCode();
            return hashCode;
        }
    }
}
