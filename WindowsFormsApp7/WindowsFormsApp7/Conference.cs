using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Conference : IEquatable<Conference>
    {
        public string id { get; set; }
        public string name { get; set; }
        public int year { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: {1} {2}", year, id, name);
        }

        public Conference(string name, int year)
        {
            id = Guid.NewGuid().ToString();
            this.name = name;
            this.year = year;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Conference);
        }

        public bool Equals(Conference other)
        {
            return other != null &&
                   id == other.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }
}
