﻿

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }

    } 
}