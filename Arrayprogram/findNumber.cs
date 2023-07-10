using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class findNumber
    {
        static void Main(string[] args)
        {
            //1.   WAP to search for a given number in an array and accordingly print the index if exists
            int[] arr = new int[10] { 22, 44, 6, 74, 8, 92, 46, 3, 5, 61 };
            int count = 0;
            Console.WriteLine("Enter number to find");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
    }
}
