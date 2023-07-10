using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrayprogram
{
    internal class frequencyOfno
    {
        static void Main(string[] args)
        {
            //WAP to count frequency of each element in an array.
            int count = 0;
            int[] num = new int[] { 2, 3, 4, 5, 2, 7 };
            int n = num.Length;
            Console.WriteLine(num);

           

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (num[i] == num[j])
                    {
                    Console.WriteLine(num[j]);

                    } 
                        
                }
                
            }

        }
    }
}
