using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Random rnd = new Random();
            int sum = 0;
            int avg = 0;
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1,11);
                Console.WriteLine("{0}",a[i]);
                sum += a[i];
            }
            avg = sum / a.Length;
            Console.WriteLine();
            Console.WriteLine("合計値:{0}", sum);
            Console.WriteLine("平均値:{0}",avg);
            Console.WriteLine();
            Console.Write("平均値より大きい数:");
                for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > avg)
                {
                    Console.Write(a[i]+" ");
                }
            }
            Console.WriteLine();
            Console.Write("平均値より小さい数:");
                for(int i = 0; i <a.Length; i++)
            {
                if (a[i] < avg)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
