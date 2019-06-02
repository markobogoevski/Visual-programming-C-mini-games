using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    enum PasswordStrenght : int
    {
        easy=1,
        normal,
        hard
    }
    class Program
    {
        public static string generatePassword(PasswordStrenght passwordStrenght)
        {
            int dif = (int)passwordStrenght;
            StringBuilder password = new StringBuilder();
            Random randomPicker = new Random();

            if(dif==1)
            {
                int randomSize = randomPicker.Next(1, 7);

                for (int i = 0; i < randomSize; i++)
                    password.Append((char)randomPicker.Next(97, 123));
            }
            else if (dif==2)
            {
                int randomSize = randomPicker.Next(6, 11);
                char[] selection = {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H'
                ,'I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

                for (int i = 0; i < randomSize; i++)
                    password.Append(selection[randomPicker.Next(0,selection.Length)]);
            }
            else
            {
                int randomSize = randomPicker.Next(10,100);
                for (int i = 0; i < randomSize; i++)
                    password.Append((char)randomPicker.Next(32, 127));
            }
            
            return password.ToString();
        }
        static void Main(string[] args)
        {
            /*
            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
            Console.ReadKey();
            
            Gorniot kod definira niza na separatori vo promenlivata separator, 
             * vo ovoj sluchaj toa e niza od samo eden element (prazno mesto). Potoa se definira nova niza
             * myWords koja treba da gi chuva zborovite otkako stringot myString kje bide podelen na delovi 
             * vo odnos na separatorot. Delenjeto se pravi so f-jata .Split(separator) so shto stringot se deli
             * na zborovi po prazni mesta. Potoa sekoj zbor se pechati na ekran.
             */

            string tries;
            Console.WriteLine("Try to guess the passwords!");
            tries = Console.ReadLine();

            string[] passwords = tries.Split(' ');
            string[] generatedPasswords = new string[3];
            for (int i = 1; i <= 3; i++)
            {
                PasswordStrenght passwordStrenght = (PasswordStrenght)i;
                generatedPasswords[i-1] = generatePassword(passwordStrenght);
            }
            

            StringBuilder stringBuilder = new StringBuilder();
            int count = 0;

            foreach (string password in passwords)
                foreach (string correct in generatedPasswords)
                    if (password.Equals(correct, StringComparison.Ordinal))
                    {
                        stringBuilder.Append("You guessed the password: " + correct + " correct!\n");
                        count++;
                    }

            Console.WriteLine("The generated passwords were: {0}, {1} and {2} sorted by difficulty..", generatedPasswords[0], generatedPasswords[1], generatedPasswords[2]);
            if (count == 0)
                Console.WriteLine("You didn't guess any...");
            else 
                Console.WriteLine(stringBuilder.ToString());


            Console.ReadKey();
        }
    }
}
