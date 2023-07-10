using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class minmax
    {
        static void Main(string[] args)
        {
            // 5.WAP to find the maximum and minimum value in an array.

            int[] arr = new int[5] { 4, 5, 67, 8, 99 };
            int i, max, min;

            max = arr[0];
            min = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maxmimum value = " + max + "\n");



            Console.Write("Minimum value = " + min + "\n");

        }
    }
}
