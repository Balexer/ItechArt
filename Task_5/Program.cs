using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sumOfPositive = 0;
            int sumOfNegative = 0;
            if (a >= 0) sumOfPositive++;
            else
            {
                sumOfNegative++;
            }

            if (b >= 0) sumOfPositive++;
            else
            {
                sumOfNegative++;
            }

            if (c >= 0) sumOfPositive++;
            else
            {
                sumOfNegative++;
            }

            Console.WriteLine($"Количество положительных чисел {sumOfPositive}");
            Console.WriteLine($"Количество отрицательных чисел {sumOfNegative}");
        }
    }
}