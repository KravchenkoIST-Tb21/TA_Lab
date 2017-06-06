
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace TeorAlg_lab6_var10
{
    class Program

    {
        static void Main(string[] args)
        {
            List<int> matchKNumbers = new List<int>();
            Console.WriteLine("Квадратная матрица");

            int[,] matrix = new int[8, 8];

            #region Заполнение матрицы (двумерного массива)
            Random rand = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = rand.Next(-8, 8);

                }
            }
            #endregion

            #region Форматированный вывод матрицы
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("______");
                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("|" + String.Format("{0,5:0.#}", matrix[i, j]));
                }
                Console.WriteLine("|");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("|_____");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine("\n");
            for (int i = 0; i < 8; i++)
            {
                bool doesMatch = true;
                for (int j = 0; j < 8; j++)
                    if (matrix[i, j] != matrix[j, i])
                        doesMatch = false;
                if (doesMatch)
                    matchKNumbers.Add(i);
            }
            foreach (int number in matchKNumbers)
                Console.WriteLine("k = {0}", number);

            for (int i = 0; i < 8; i++)
            {
                bool hasNegativeItem = false;
                for (int j = 0; j < 8; j++)
                    if (matrix[i, j] < 0.0)
                        hasNegativeItem = true;
                if (hasNegativeItem)
                {
                    double sum = 0.0;
                    for (int j = 0; j < 8; j++)
                        sum += matrix[i, j];
                    Console.WriteLine("Сумма строки {0} равна {1}", i, sum);
                    Console.ReadKey(true);
                }
            }
        }
    }
}
                      

            
    


