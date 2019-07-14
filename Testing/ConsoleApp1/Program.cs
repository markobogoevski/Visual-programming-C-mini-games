using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Test
    {
        public static void Main(String[] args)
        {
            List<int> IntList = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> list =
                from number in IntList
                where number > 10
                orderby number ascending
                select number + 5;
        }
    }

}
