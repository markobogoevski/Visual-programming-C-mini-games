using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    [Serializable]
    class Money
    {
        public int NumberOfMoneyBanks { get; set; }

        public Money(int NumberOfMoneyBanks = 1)
        {
            this.NumberOfMoneyBanks = NumberOfMoneyBanks;
        }

        public void addMoneyBank()
        {
            NumberOfMoneyBanks++;
        }

        public void removeMoneyBank()
        {
            NumberOfMoneyBanks--;
        }
    }
}
