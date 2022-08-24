using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int m, n;
            int max= 0, min= 9;
            Random r = new Random();
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    a[m, n] = m + n;
                    a[m, n] = r.Next(0, 10);
                    if (a[m,n] < min)
                    {
                        min = a[m,n];
                    }
                    if (a[m,n] > max)
                    {
                        max = a[m,n];
                    }
                }
            }
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    Console.Write(a[m, n]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("最大値:" + max);
            Console.WriteLine("最小値:" + min);
        }
    }
}
