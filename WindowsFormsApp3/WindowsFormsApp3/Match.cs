using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
  
    public class Match
    {
        public string MatchCode { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public decimal []coef { get; set;}

        public Match(string matchCode, Team homeTeam, Team awayTeam,decimal[]coef)
        {
            MatchCode = matchCode;
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.coef = new decimal[3];
            for (int i = 0; i < 3; i++)
                this.coef[i] = coef[i];
        }

        public override string ToString()
        {
            return MatchCode+" - "+homeTeam + " vs: " + awayTeam;
        }

        public override bool Equals(object obj)
        {
            var match = obj as Match;
            return match != null &&
                   MatchCode == match.MatchCode;
        }

        public override int GetHashCode()
        {
            return -803875933 + EqualityComparer<string>.Default.GetHashCode(MatchCode);
        }
    }
}
