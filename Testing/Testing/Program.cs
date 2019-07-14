using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Stack
    {
        private class Entry
        {
            private Entry next;
            public object data;

            public Entry(Entry next, object data)
            {
                this.next = next;
                this.data = data;
            }

        }

        private Entry top;
        public void Push(Object data)
        {
            top = new Entry(top, data);
        }


    }
}
