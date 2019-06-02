using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    [Serializable]
    public class Coins
    {
        public int CoinsNumber { get; set; }
        public Coins(int CoinsNumber = 1)
        {
            this.CoinsNumber = CoinsNumber;
        }

        public void addCoin()
        {
            CoinsNumber++;
        }

        public void removeCoin()
        {
            if (CoinsNumber >= 1)
            {
                CoinsNumber--;
            }
        }
    }
}
