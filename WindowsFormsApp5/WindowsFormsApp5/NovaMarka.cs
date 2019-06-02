using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class NovaMarka : IEquatable<NovaMarka>
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return String.Format("Marka - ime: {0},  shifra{1} ", Name, Code);
        }

        public NovaMarka(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as NovaMarka);
        }

        public bool Equals(NovaMarka other)
        {
            return other != null &&
                   Name == other.Name &&
                   Code == other.Code;
        }

        public override int GetHashCode()
        {
            var hashCode = -1719721206;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            return hashCode;
        }
    }
}
