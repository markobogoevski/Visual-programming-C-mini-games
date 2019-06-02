using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    [Serializable]
    class Coins
    {
        public int NumberOfCoins { get; set; }

        public Coins(int NumberOfCoins = 1)
        {
            this.NumberOfCoins = NumberOfCoins;
        }

        public void addCoin()
        {
            NumberOfCoins++;
        }

        public void removeCoin()
        {
            if(NumberOfCoins>=1)
            NumberOfCoins--;
        }
    }
}
