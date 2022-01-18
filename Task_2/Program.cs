using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && c + b > a)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}