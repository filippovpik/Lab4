﻿namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int n = Convert.ToInt32 (Console.ReadLine()); //input n
            int fact = 1;

            for (int i = 1; i <= n; i++)

            {
                fact=fact*i;
            }

            Console.WriteLine(fact);

            Console.ReadKey();
        }
    }
}
