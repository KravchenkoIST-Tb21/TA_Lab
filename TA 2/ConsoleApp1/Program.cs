﻿using System;

namespace The_saga
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x, y = 0, R;
            Console.WriteLine("Первая часть задания"); //Задание. Часть 1
            do
            {
                Console.Write("Введите x=");
                x = Convert.ToDouble(Console.ReadLine());
                if (x < -3)
                    y = 3;
                else if (-3 <= x && x <= 3)
                    y = 3 - Math.Sqrt(9 - Math.Pow((x), 2));
                else if (3 < x && x < 6)
                    y = -2 * x + 9;
                else if (6 <= x)
                    y = x - 9;
                Console.WriteLine("y=" + y);
                Console.WriteLine("Приступить ко второй части задания? (Да - любой символ, Нет - нет)");
            }
            while (Console.ReadLine() == "нет");
            Console.WriteLine("Вторая часть задания"); //Задание. Часть 2
            do
            {
                Console.Write("Введите R=");
                R = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите у=");
                y = Convert.ToDouble(Console.ReadLine());
                if  ((y <= Math.Pow((x + R) + (y - R), 2)) || (y <= 0 && y >= -R && x >= 0 && x <= 2 * R))
                    Console.WriteLine("Пара (х;у) принадлежит области");
                else
                    Console.WriteLine("Пара (х;у) не принадлежит области");
                    Console.WriteLine("Завершить задание? (Да - любой символ, Нет - нет)");
                
            }
            while (Console.ReadLine() == "нет");

        }
    }
}

