using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class NotSameValue
    {
        static void Main(string[] args)
        {



            //10. WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.



            int[] array1 = { 2, 4, 21, 6, 26, 22 };

            int[] array2 = { 1, 33, 26, 4, 22, 5, 9 };

            Console.WriteLine("Array 1= ");

            foreach (int x1 in array1)
            {
                Console.WriteLine(x1);
            }

            Console.WriteLine("Array 2= ");

            foreach (int x2 in array2)
            {
                Console.WriteLine(x2);
            }

            var final = array1.Union(array2).ToArray();

            Console.WriteLine("New array:");
            Array.ForEach(final, i => Console.WriteLine(i));
        }


    
    }
}
