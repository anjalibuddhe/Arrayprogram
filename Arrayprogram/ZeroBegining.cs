using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{   //Move zeros to beginning or end of array. 
//e.g. if given array is { 2 , 10 , 0 ,5 ,3, 0, 4 ,1}
//then output array should be 
//a. { 0,0,2,10,5,3,4,1} 
//b. { 2,10,5,3,4,1,0,0}
internal class ZeroBegining
    {
        static void Main(string[] args)
        {
            int[] arr =new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    //Console.WriteLine(arr[i]);
                }
               
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
               
            }
            for (int i = 0; i <arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();

        }
    }
}
