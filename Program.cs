using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int long_array = 11, MAX = 100, MIN = -100;
            int[] array = new int[long_array];
            for (int i = 0; i < long_array; i++)
            {
                array[i] = Rand(MAX, MIN);
                Thread.Sleep(150);
            }
            Console.WriteLine("     Содержание массива");
            Console.WriteLine("     _________________");
            Console.WriteLine("     |  ID |array[ID]|");
            Console.WriteLine("     |_____|_________|");
            for (int id = 0; id < long_array; id++)
            {
                Console.WriteLine("     |" + String.Format("{0,5:0.#}", id) + "|" + String.Format("{0,9:0.##}", array[id]) + "|");
                Console.WriteLine("     |_____|_________|");
            }



           
            Console.WriteLine("\n\tНомер максимального элемента массива: {0}",
                Array.IndexOf(array, array.Max()));

            try
            {
                int firstZero = Array.IndexOf(array, 0);
                int secondZero = Array.IndexOf(array, 0, firstZero + 1);
                Console.WriteLine("произведение: {0}", array
                    .Skip(firstZero + 1)
                    .Take(secondZero - firstZero - 1)
                    .Aggregate((x, y) => x * y));

            }
            catch (Exception)
            {
                Console.WriteLine("\n\tНет нулевых значений");
            }
            int l = array.Length;
            int[] newArray = new int[l];
            for (int id = 0; id < l; id++)
            {
                newArray[id % 2 * l / 2 + id / 2] = array[id];
            }
            Console.WriteLine("\n\tИзмененный массив");
            Console.WriteLine("     _________________");
            Console.WriteLine("     |  ID |array[ID]|");
            Console.WriteLine("     |_____|_________|");
            for (int id = 0; id < long_array; id++) 
            {
                Console.WriteLine("     |" + String.Format("{0,5:0.#}", id) + "|" + String.Format("{0,9:0.##}",newArray[id]) + "|");
                Console.WriteLine("     |_____|_________|");
            }
            Console.ReadKey(true);



        }
        public static int Rand(int max, int min)
        {

            Random rand = new Random();

            return rand.Next(min, max);

        }
    }
}
    



