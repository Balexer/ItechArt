using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество программистов");
            int numberOfDevelopers = Convert.ToInt32(Console.ReadLine());
            String endingOv = "ов";
            String endingA = "а";

            if (numberOfDevelopers == 1)
            {
                Console.WriteLine($"{numberOfDevelopers} Программист");
            }
            else if (numberOfDevelopers > 4 | numberOfDevelopers == 0)
            {
                Console.WriteLine($"{numberOfDevelopers} Программист{endingOv}");
            }
            else
            {
                Console.WriteLine($"{numberOfDevelopers} Программист{endingA}");
            }
        }
    }
}