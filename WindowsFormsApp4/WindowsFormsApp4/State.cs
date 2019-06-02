using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    

    public class State : IEquatable<State>
    {
        public string Name { get; set; }
        public string Abbr { get; set; }
        public string mainCity { get; set; }

        public State(string name, string abbr, string mainCity)
        {
            Name = name;
            Abbr = abbr;
            this.mainCity = mainCity;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as State);
        }

        public bool Equals(State other)
        {
            return other != null &&
                   Abbr == other.Abbr;
        }

        public override int GetHashCode()
        {
            return 1794401422 + EqualityComparer<string>.Default.GetHashCode(Abbr);
        }

        public override string ToString()
        {
            return String.Format("{0} - Name: {1}, capital city: {2}\n", Abbr, Name, mainCity);
        }
    }
}
