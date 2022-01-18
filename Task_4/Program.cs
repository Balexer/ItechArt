using System;

namespace Task_4
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
                if (a > 0) sumOfPositive++;
                if (b > 0) sumOfPositive++;
                if (c > 0) sumOfPositive++;
                
                Console.WriteLine(sumOfPositive);
            
        }
    }
}