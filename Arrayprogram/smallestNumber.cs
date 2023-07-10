using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class smallestNumber
    {
        static void Main(string[] args)
        {
            //8.WAP to find the second smallest element in an array.


            int[] arr = { 111, 13, 25, 9, 34, 1 };
            int n = arr.Length;


            Array.Sort(arr);

            Console.WriteLine("second smallest element is " + arr[1]);

        }
    }
}
