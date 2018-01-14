using System;
using System.Linq;
namespace CrackingTheCoding.DataStructures
{
    public class Strings_MakingAnagrams
    {

        private static string charsAlreadyChecked = "";

        public Strings_MakingAnagrams()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            NumberNeeded(a, b);
        }

        private static void NumberNeeded(string a, string b)
        {
            int n_numbersRemoved = BuildAnagramString(a, b);
            n_numbersRemoved += BuildAnagramString(b, a);

            Console.WriteLine(n_numbersRemoved);
        }

        private static int BuildAnagramString(string a, string b)
        {

            var n_numbersRemoved = 0;

            foreach (char charA in a)
            {
                if (charsAlreadyChecked.Contains(charA)) continue;

                charsAlreadyChecked += charA;

                var n_charA_inStringA = a.Count(c => c == charA);
                var n_charA_inStringB = b.Count(c => c == charA);

                if (n_charA_inStringA == n_charA_inStringB || n_charA_inStringA < n_charA_inStringB)
                {
                    n_numbersRemoved += n_charA_inStringB - n_charA_inStringA;
                }
                else
                {
                    n_numbersRemoved += n_charA_inStringA - n_charA_inStringB;
                }
            }
            return n_numbersRemoved;
        }
    }
}
