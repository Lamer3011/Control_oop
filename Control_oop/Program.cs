using System;
using System.Linq;

namespace Control_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
                { 84, 12, 56, 87, 36, 31, 52, 24, 50 }, //
                { 80, 26, 36, 54, 22, 76, 94, 42, 26 }, //
                { 25, 52, 76, 94, 22, 46, 54, 62, 23 }, // 
                { 11, 12, 14, 21, 62, 36, 54, 22, 26 }, // 
                { 99, 15, 66, 74, 32, 26, 64, 42, 52 }, // Двохвимірний масив з випадковими числами
                { 83, 32, 46, 14, 14, 26, 76, 42, 36 }, // 
                { 88, 52, 26, 44, 12, 46, 84, 65, 66 }, //
                { 14, 42, 66, 44, 62, 36, 44, 32, 26 }, // 
                { 69, 62, 56, 44, 22, 86, 74, 62, 56 }, //
            };
            var max = Enumerable.Range(0, arr.GetLength(0)).Select(e => arr[e, e]).Max(); // знаходження максимального числа
            var min = Enumerable.Range(0, arr.GetLength(0)).Select(e => arr[e, e]).Min(); // знаходження мінімального числа

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
