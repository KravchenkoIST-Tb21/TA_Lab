using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, a;
            Console.WriteLine("введите значение а=");
            a = Convert.ToDouble(Console.ReadLine());
            z1 = Math.Pow(Math.Cos(Math.PI * 3 / 8 - a / 4), 2) - Math.Pow(Math.Cos(Math.PI * 11 / 8 + a / 4), 2);
            z2 = Math.Sqrt(2) / 2 * Math.Sin(a / 2);
            Console.WriteLine("z1="+z1);
            Console.WriteLine("z2=" + z2);
            Console.ReadKey(true);

        }
    }
}
