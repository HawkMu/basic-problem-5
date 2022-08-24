using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            Random r = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1,11);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            for(int i = 0; i < a.Length; i++)
            {
             for(int j = 0; j < a[i]; j++)
                {
                    Console.Write("*");
                }
             Console.WriteLine() ;
            }
            Console.WriteLine();
        }
    }
}
