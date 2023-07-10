using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class CountNegetive
    {
        static void Main(string[] args)
        {
            // 3.WAP to print all negative elements in an array and also count total number of negative elements in an array.
            int[] arr = new int[10];

            Console.WriteLine("Enter size of the array");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements in array");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("negative elements in array");
            for (int i = 0; i < num; i++)
            {

                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
