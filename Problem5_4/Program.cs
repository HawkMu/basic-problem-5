﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_4
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
                data[i] = rnd.Next(1,101);
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            Console.Write("50以上の数:");
            for(i=0; i < data.Length; i++)
            {
                if (data[i] >= 50)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("50未満:");
            for (i = 0; i < data.Length; i++)
            {
                if(data[i] < 50)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
