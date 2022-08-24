using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int m, n;
            Random r = new Random();
            for(m = 0; m < 3; m++)
            {
                for(n = 0; n < 3; n++)
                {
                    a[m, n] = m + n;
                    a[m, n] = r.Next(0, 10);
                }
            }
            for(m = 0; m < 3; m++)
            {
                for(n = 0; n < 3; n++)
                {
                    Console.Write(a[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
