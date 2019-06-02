using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanWord
    {
        public string WordToGuess { get; set; }
        public HashSet<char> CharactersNotGuessed { get; set; }
        public HashSet<char> CharactersTried { get; set; }
        public int numberOfGuesses { get; set; }
        public static int MAX_GUESSES = 5;

        public HangmanWord(String word) 
        {
            CharactersNotGuessed = new HashSet<char>();
            CharactersTried = new HashSet<char>();
            WordToGuess = char.ToLower(word.ElementAt(0)) + word.Substring(1);
            setInitializer();
        }
        public bool solvedGame()
        {
            if (CharactersNotGuessed.Count == 0 && numberOfGuesses != MAX_GUESSES)
                return true;
            return false;
        }
        public bool guessLetter(char letter)
        {

            letter = char.ToLower(letter);
            if (!CharactersTried.Contains(letter))
            {
                CharactersTried.Add(letter);
                if (WordToGuess.Contains(letter))
                {
                    CharactersNotGuessed.Remove(letter);
                    return true;
                }
                else
                {
                    numberOfGuesses++;
                    return false;
                }
            }return true;
        }
        public string refreshGuessed()
        {
            StringBuilder word = new StringBuilder();
            foreach(char c in WordToGuess)
            {
                if (CharactersNotGuessed.Contains(char.ToLower(c)))
                    word.Append("_ ");
                else
                    word.Append(c + " ");
            }
            return word.ToString();
        }
        public string refreshTotalLetters()
        {
            StringBuilder word = new StringBuilder();

            for(char c = 'A'; c <= 'Z'; c++)
            {
                if (CharactersTried.Contains(char.ToLower(c)))
                    word.Append(char.ToLower(c) + " ");
                else
                    word.Append("_ ");
            }

            return word.ToString();
        }
        public void setInitializer()
        {
            foreach(char c in WordToGuess)
            {
                CharactersNotGuessed.Add(char.ToLower(c));
            }
        }
    }
}
