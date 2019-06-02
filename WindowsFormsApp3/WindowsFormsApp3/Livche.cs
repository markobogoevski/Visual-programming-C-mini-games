using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Livche
    {
        public List<PlayedMatch> playedMatches { get; set; }

        public Livche()
        {
            this.playedMatches = new List<PlayedMatch>();
        }

        public void addPlayedMatch(PlayedMatch played)
        {
            playedMatches.Add(played);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(PlayedMatch played in playedMatches)
                stringBuilder.Append(played);

            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
