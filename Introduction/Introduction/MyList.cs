using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public static class MyList
    {
        public static int Count<T>(this IEnumerable<T> incSequence)
        {
            int num = 0;
            foreach (var item in incSequence)
            {
                num++;
            }
            return num;
        }
    }
}
