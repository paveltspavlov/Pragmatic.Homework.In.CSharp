using System;

namespace Homework1Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter first number:");
           int num1 = Console.ReadLine();

           Console.WriteLine("Enter second number:");
           int num2 = Console.ReadLine();

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} should be different");
                return;
            } else if (num1 == 0 && num2 == 0)
            {
                Console.WriteLine($"Number {num1} and {num2} should be different than 0");
                return;
            } else
            {
                num1=num1+num2;
                num2=num1-num2;
                num1=num1-num2;

                Console.WriteLine("The numbers are exchanged");
                Console.WriteLine($"The first now is {num1} and the second one is {num2}");
            }
        }
    }
}
