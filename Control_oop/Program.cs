using System;
using System.Linq;

namespace Control_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
                { 68, 62, 56, 37, 36, 60, 52, 64, 50 }, //
                { 66, 50, 36, 54, 41, 36, 64, 42, 46 }, //
                { 35, 52, 45, 44, 52, 46, 54, 62, 53 }, // 
                { 36, 52, 64, 41, 62, 36, 54, 42, 56 }, // 
                { 46, 55, 66, 64, 37, 26, 64, 52, 42 }, // Двохвимірний масив з випадковими числами
                { 66, 35, 46, 54, 50, 56, 65, 42, 36 }, // 
                { 68, 55, 36, 44, 62, 46, 36, 65, 66 }, //
                { 37, 42, 66, 44, 62, 36, 44, 62, 36 }, // 
                { 69, 62, 56, 44, 42, 36, 54, 32, 56 }, //
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
