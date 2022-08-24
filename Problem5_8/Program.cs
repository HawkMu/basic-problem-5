using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int Pcount = 0;
            int Mcount = 0;
            int Count = 0;

            Random rnd = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10,11);
                Console.Write(a[i]+" ");
                if(a[i] > 0)
                {
                    Pcount++;
                }
                if(a[i] < 0)
                {
                    Mcount++;
                }
                if (a[i] == 0)
                {
                    Count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("0より大きい数:" + Pcount + "個");
            Console.WriteLine("0より小さい数:" + Mcount + "個");
            Console.WriteLine("0の個数:" + Count + "個");
        }
    }
}
