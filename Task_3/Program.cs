using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                num++;
            else if (num < 0)
                num = num - 2;
            else
            {
                num = 10;
            }
            Console.WriteLine(num);
        }
    }
}