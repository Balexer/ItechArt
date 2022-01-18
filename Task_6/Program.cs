using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a > b) Console.WriteLine($"Большее {a}");
            else if (a == b) Console.WriteLine($"Числа {a} и {b} равны");
            else
            {
                Console.WriteLine($"Большее {b}");
            }
        }
    }
}