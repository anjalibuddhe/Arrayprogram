using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprogram
{
    internal class duplicate
    {
        static void Main(string[] args)
        {
            // 6. WAP to find and count total number of duplicate elements in an array.


            int[] num = new int[10] { 1, 3, 45, 56, 67, 3, 1,3, 45,  1 };
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        //count++;
                        Console.WriteLine(num[j]);
                        break;
                    }


                }
            }
        }
    }
}
