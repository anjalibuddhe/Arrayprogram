
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrayprogram
{
    internal class uniqueElement
    {
        static void Main(string[] args)
        {
            // 7.WAP to print all unique elements in the array.


            int[] items = new int[10] { 21, 34, 56, 76, 21, 45, 34, 87, 99, 76 };
            int n = items.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            //    int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 1, 2, 7, 3 }; for (int i = 0; i < arr.Length; i++)

            //        int a = 0

            //        for (int i = 0; j < i; j++)

            //    {

            //        if (arr[i] == arr[j]) // element exist

            //        {

            //            a = 1;

            //            break;

            //        }

            //    }

            //    if (a == 0)

            //        Console.WriteLine(arr[i]);
            }
        }
    }
}
