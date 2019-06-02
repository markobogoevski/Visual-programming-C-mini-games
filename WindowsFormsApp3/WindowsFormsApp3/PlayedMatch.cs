using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class PlayedMatch:Match
    {
        public int typeOfPlay { get; set; }
        public PlayedMatch(string matchCode, Team homeTeam, Team awayTeam,decimal[]decimals,int typeOfPlay):base(matchCode,homeTeam,awayTeam,decimals)
        {
            this.typeOfPlay = typeOfPlay;
        }

        public override string ToString()
        {
            return homeTeam.Name + " vs " + awayTeam.Name;
        }
    }
}
