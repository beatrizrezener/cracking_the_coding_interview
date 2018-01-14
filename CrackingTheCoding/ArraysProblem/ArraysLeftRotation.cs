using System;
namespace CrackingTheCoding.ArraysProblem
{
    public class ArraysLeftRotation
    {
        public ArraysLeftRotation()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int nIntegers = Convert.ToInt32(tokens_n[0]);
            int nLeftRotations = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(a_temp, Int32.Parse);

            PrintArrayContent(LeftRotation(array, nIntegers, nLeftRotations));
        }

        private static int[] LeftRotation(int[] array, int nIntegers, int nLeftRotations)
        {

            var rotatedArray = new int[nIntegers];

            for (int i = 0; i < nIntegers; i++)
            {
                var newIndex = i - nLeftRotations;
                if (newIndex < 0)
                {
                    newIndex = nIntegers + newIndex;
                }
                rotatedArray[newIndex] = array[i];
            }

            return rotatedArray;
        }

        private static void PrintArrayContent(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
