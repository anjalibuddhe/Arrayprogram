using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find pair of elements in array whose number is given number.
//e.g.Given array is { 4,5,7,1,2,3,0} If number given is 7. Then pairs whose sum is equal to given 
//number are – (4,3) (5, 2)(7, 0)

namespace Arrayprogram
{
    internal class PairSum
    {
        static void Main(string[] args)
        {
            int[] arr=new int[] { 4, 5, 7, 1, 2, 3, 0 };
            int num = 7;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length-1; j++)
                {
                    if (num == arr[i] + arr[j])
                    {
                        
                        Console.WriteLine($"pair is ({arr[i]}, {arr[j]} ) ");
                    }
                }
            }
        }
    }
}
