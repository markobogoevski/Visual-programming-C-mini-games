using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Player : IComparable<Player>, IEquatable<Player>
    {
        public int TimeInSeconds { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
            TimeInSeconds = 60;
            Points = 0;
        }

        public override string ToString()
        {
            return String.Format("Player : {0} - Points {1} \n", Name, Points);
        }

        public bool guessEquation(Equation equation,int guess)
        {
            if (equation.tryGuess(guess)){
                Points++;
                if (Points % 10 == 0)
                    TimeInSeconds += 10;
                return true;
            }
            return false;
        }
        public int CompareTo(Player other)
        {
            return -(Points - other.Points);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Player);
        }

        public bool Equals(Player other)
        {
            return other != null &&
                   Points == other.Points &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 747190748;
            hashCode = hashCode * -1521134295 + Points.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
