using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int Count = 0;
            Random r = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0,101);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("50以上の数:");
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 50)
                {
                    Console.Write(a[i]+" ");
                }
            }
            Console.WriteLine();
            Console.Write("50未満の数:");
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] < 50)
                {
                    Console.Write(a[i] + " ");
                }
                if (a[i] == 0)
                {
                    
                    Count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("0個の個数:"+Count+"個");

        }
    }
}
