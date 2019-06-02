using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Driver : IEquatable<Driver>
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public bool IsFirst { get; set; }
        public List<Lap> Laps { get; set; }

        public override string ToString()
        {
            return String.Format("{0}({1})-{2}", Name, Age, IsFirst);
        }

        public Driver(string name, int age, bool isFirst)
        {
            Name = name;
            Age = age;
            IsFirst = isFirst;
            Laps = new List<Lap>();
        }

        public void addLap(Lap lap)
        {
            Laps.Add(lap);
        }

        public void removeLap(Lap lap)
        {
            Laps.Remove(lap);
        }

       

        public Lap bestLap()
        {
            Lap fastestLap = Laps.ElementAt(0);
            foreach(Lap lap in Laps)
            {
                if(lap.lapToSeconds()<fastestLap.lapToSeconds())
                    fastestLap = lap;
            }

            return fastestLap;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Driver);
        }

        public bool Equals(Driver other)
        {
            return other != null &&
                   Name == other.Name &&
                   Age == other.Age &&
                   IsFirst == other.IsFirst &&
                   EqualityComparer<List<Lap>>.Default.Equals(Laps, other.Laps);
        }

        public override int GetHashCode()
        {
            var hashCode = 1804216262;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + IsFirst.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Lap>>.Default.GetHashCode(Laps);
            return hashCode;
        }
    }
}
