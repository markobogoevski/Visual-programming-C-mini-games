using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TipsAndTraps
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[]
            {
                "Sarah",
                "Marko",
                "Darko",
                "Lily",
                "Petar"
            };

            var endRes=names.Aggregate("",(res, el) => res += el);

        }
    }
}
