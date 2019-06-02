using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Team(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return Name+" - "+Country;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static explicit operator Team(ListBox.SelectedObjectCollection v)
        {
            throw new NotImplementedException();
        }
    }
}
