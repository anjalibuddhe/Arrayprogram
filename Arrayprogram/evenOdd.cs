using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class evenOdd
    {
        static void Main(string[] args)
        {
            //4. WAP to put even and odd elements of array in two separate arrays.

            int[] arr1 = new int[10] { 2,11,2,3,45,6,7,8,9,31 };
           

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr1[i]);
            }
            int j = 0;int k = 0;
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(arr2[i]);
            }


            
        }
    }
}
