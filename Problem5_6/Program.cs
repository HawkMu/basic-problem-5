using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Random rnd = new Random();
            double avg = 0.0;
            int min = 101, max = 0;
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(1,101);
                Console.Write("{0} ",data[i]);
                if (data[i] < min)
                {
                    min = data[i];
                }
                if(data[i] > max)
                {
                    max = data[i];
                }
            }
            avg = (double)data.Length;
            Console.WriteLine();
            Console.WriteLine("最大値:"+max);
            Console.WriteLine("最小値:"+min);
            Console.WriteLine("平均値:"+avg);
        }
    }
}
