using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class WordPicker
    {
        public static string[] words;
        public Random random;
        public WordPicker()
        {
            random = new Random();
            words=new string[]{"Marko","Darko","Venezuella",
        "Madagascar","Torino","Los Angeles","New York","Boston","Denver",
        "Washington","Skopje"};
        }

        public String pickNextWord()
        {
            int randomIndex = random.Next(words.Length);
            return words[randomIndex];
        }
    }
}
