using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Lap : IEquatable<Lap>
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }

        public override string ToString()
        {
            return String.Format("{0}:{1}", Minutes, Seconds);
        }
        public int lapToSeconds()
        {
            return Minutes * 60 + Seconds;
        }
        public Lap(int seconds, int minutes)
        {
            Seconds = seconds;
            Minutes = minutes;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Lap);
        }

        public bool Equals(Lap other)
        {
            return other != null &&
                   Seconds == other.Seconds &&
                   Minutes == other.Minutes;
        }

        public override int GetHashCode()
        {
            var hashCode = -689532248;
            hashCode = hashCode * -1521134295 + Seconds.GetHashCode();
            hashCode = hashCode * -1521134295 + Minutes.GetHashCode();
            return hashCode;
        }
    }
}
