using System;

namespace TA_Lab_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = -7, y = -1, dx, R;
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Tablica znachenij funkcii:");
            Console.WriteLine("    _______________");
            Console.WriteLine("   |   X   |   Y   |");
            Console.WriteLine("   |_______|_______|");

            for (dx = 1; x < 18; x = x + dx)
            {

                if (x < -3)
                    y = 3;
                else if (-3 <= x && x <= 3)
                    y = 3 - Math.Sqrt(9 - Math.Pow((x), 2));
                else if (3 < x && x < 6)
                    y = -2 * x + 9;
                else if (6 <= x)
                    y = x - 9;

                Console.WriteLine("   |" + String.Format("{0,4:0.#}", x) + "   |" + String.Format("{0,5:0.##}", y) + "  |");
                Console.WriteLine("   |_______|_______|");
            }
            Console.WriteLine("Zadanie 2");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Vvedite R=");
                R = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite у=");
                y = Convert.ToDouble(Console.ReadLine());
                if (y <= Math.Pow((x - R), 2) && x <= Math.Pow(((y + R)), 2) && x + y <= Math.Pow((R), 2))
                    Console.WriteLine("Popadanie");
                else if (y <= 0 && y >= -R && x >= 0 && x <= 2 * R)
                    Console.WriteLine("Popadanie");
                else
                    Console.WriteLine("Mimo");
            }
            Console.WriteLine("Zadanie 3");
            double  xn, xk, gx, e = 1E-15;
            Console.Write("X nachalnoe: ");
            xn = Convert.ToDouble(Console.ReadLine());
            Console.Write("X konechnoe: ");
            xk = Convert.ToDouble(Console.ReadLine());
            Console.Write("dX: ;");
            gx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("     ________________________________");
            Console.WriteLine("     |   x |asin_def|   N |arcsin(x)|");
            Console.WriteLine("     |_____|________|_____|_________|");
            for (x = xn; x <= xk; x += gx)
                if (Math.Abs(x) <= 1)
                {
                    int n = 1, mul = -1, d = 1;
                    double sum = Math.PI / 2, x_n = x;
                    double el = sum, oldel;
                    do
                    {
                        oldel = el;
                        el = x_n / d;
                        sum += mul * el;
                        x_n *= x * x;
                        n++;
                        mul = -mul;
                        d += 2;
                    } while (Math.Abs(el - oldel) > e);
                    Console.WriteLine("     |" + String.Format("{0,5:0.#}", x) + "|" + String.Format("{0,8:0.####}", sum) + "|" + String.Format("{0,5:0}", n - 1) + "|" + String.Format("{0,9:0.####}", Math.PI / 2 - Math.Atan(x)) + "|");
                    Console.WriteLine("     |_____|________|_____|_________|");

                }

            Console.ReadKey();
            Console.ReadKey(true);
        }
    }
}
