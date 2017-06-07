using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace TA_6
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            StreamReader f = File.OpenText("test.txt");
            string text = f.ReadToEnd();
            Console.WriteLine("Исходный текст: ");
            Console.WriteLine(text);
            Console.WriteLine("\n");
            Console.WriteLine(File.ReadAllText("test.txt").Split(' ').Count(s => s.Length <= 4));
            Console.ReadKey();
        }
    }
}
