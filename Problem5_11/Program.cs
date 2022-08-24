using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Random r = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1,101);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.Write("0以上60未満:");
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0 && a[i] < 60)
                {
                    Console.Write(a[i]+" ");
                }
            }
            Console.WriteLine();
            Console.Write("60以上80未満:");
            for( int i = 0; i < a.Length; i++)
            {
                if(a[i] >= 60 && a[i] < 80)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("80以上:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 80)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
