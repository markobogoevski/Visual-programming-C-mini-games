using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{
    class ProcessData
    {
        public void Process(int x,int y,Action<int,int>action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed"); 
        }
    }
}
