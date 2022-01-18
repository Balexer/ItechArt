using System;
using System.ComponentModel;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine($"Число положительно и количество цифр в числе {num.ToString().Length}");
            }
            else
            {
                Console.WriteLine($"Число отрицательно и количество цифр в числе  {num.ToString().Length - 1}");
            }


        }
    }
}