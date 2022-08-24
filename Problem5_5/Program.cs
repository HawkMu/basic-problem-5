using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Random rnd = new Random();
            int i;

            for(i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(1,11);
                Console.Write("{0} ",data[i]);
            }
            Console.WriteLine();
            Console.Write("3の倍数:");
            for(i = 0; i < data.Length; i++)
            {
                if(data[i] %3 == 0)
                {
                    Console.Write(data[i]+" ");
                }
            }
            Console.WriteLine();
            Console.Write("3の倍数以外の数:");
            for( i = 0; i < data.Length; i++)
            {
                if(data[i] %3 != 0)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
