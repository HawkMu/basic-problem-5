using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            Random rnd = new Random();
            int i;
            for(i = 0; i < a.Length; i++)
            {
                int dice = rnd.Next(1, 11);
                Console.Write("a[{0}]={1} ",i,dice);
                if (dice == 10)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}