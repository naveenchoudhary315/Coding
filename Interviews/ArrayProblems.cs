using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    internal static class ArrayProblems
    {
        public static int[] Merge2Arrays()
        {
            int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] n2 = new int[] { 4, 5, 6 };
            for (int i = 0; i < n1.Length; i++)
            {
                if (n1[i] == 0)
                {
                    for (int j = 0; j < n2.Length; j++, i++)
                    {
                        n1[i] = n2[j];
                    }
                }
            }
            return n1;

        }

        public static int[] FindMissingAndRepeatedValue()
        {


            return null;
        }


        public static void FindDignoalOfMatrix()
        {
            var matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }
        }
        public static void SotrString(string input = "Naveen")
        {
            var res = input.OrderBy(x => x).ToArray();
        }

        public static void BubbleSort(string input = "Naveen")
        {
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) // ascending order
                    {
                        // swap
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            string sorted = new string(arr);
            Console.WriteLine(sorted);
        }
    }
}
