using System;
using System.Linq;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9; //кількість рядків і стовбців
            Random rnd = new Random();
            int[,] matrix = new int[n, n];

            Console.WriteLine("Original matrix:"); //Вивід вихідної матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(35, 70);
                    Console.Write("{0,3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            int[] tempColumn = new int[n]; //Пошук індексів і необхідних стовпців.
            for (int i = 0; i < n; i++)
            {
                tempColumn[i] = matrix[i, i];
            }
            int min = Array.FindIndex(tempColumn, x => x == tempColumn.Min());
            int max = Array.FindIndex(tempColumn, x => x == tempColumn.Max());

            if (min != max) //Перестановка.
            {
                for (int i = 0; i < n; i++)
                {
                    tempColumn[i] = matrix[i, min];
                    matrix[i, min] = matrix[i, max];
                    matrix[i, max] = tempColumn[i];
                }
                //Вивід.
                Console.WriteLine("\nThe resulting matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,3} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("\nThe specified columns were not found");

            Console.Read();
        }
    }
}
