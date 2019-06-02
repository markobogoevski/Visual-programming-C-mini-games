using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Song
    {
        public string Name { get; set; }
        public int TimeDuration { get; set; }
        public double Rating { get; set; }

        public Song(string name, int timeDuration, double rating)
        {
            Name = name;
            TimeDuration = timeDuration;
            Rating = rating;
        }

        public override bool Equals(object obj)
        {
            var song = obj as Song;
            return song != null &&
                   Name == song.Name &&
                   TimeDuration == song.TimeDuration &&
                   Rating == song.Rating;
        }

        public override int GetHashCode()
        {
            var hashCode = -281573630;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + TimeDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + Rating.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Song name: {0} , song lenght: {1} , song rating : {2}", Name, TimeDuration, Rating);
        }
    }
}
