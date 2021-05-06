using System;
using System.Linq;

namespace Control_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int[,] arr = new int[n, n];
            Random r = new Random();        //заповнюємо матрицю випадковими числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(35, 70);    //кожен елемент приймає значення від 35 до 70
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            var max = Enumerable.Range(0, arr.GetLength(0)).Select(n => arr[n, n]).Max(); // знаходження максимального числа
            var min = Enumerable.Range(0, arr.GetLength(0)).Select(n => arr[n, n]).Min(); // знаходження мінімального числа

            Console.WriteLine("Matrix:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " "); // виводим в консоль матрицю
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("the minimum value on the main diagonal of the matrix: " + min); // виводим мінімальне число
            Console.WriteLine("the maximum value on the main diagonal of the matrix: " + max); // виводим максимальне число
        }
    }
}
