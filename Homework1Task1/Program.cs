using System;


namespace Pragmatic.Homework.In.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;
            string num3;

            Console.WriteLine("Please entere first number:");
            num1 = Console.ReadLine();

            Console.WriteLine("Please entere second number:");
            num2 = Console.ReadLine();

            if (Convert.ToSingle(num1) > Convert.ToSingle(num2))
            {
                Console.WriteLine($"Number {num1} should be greater than {num2}");
                return;
            }
            else if (Convert.ToSingle(num1) == Convert.ToSingle(num2))
            {
                Console.WriteLine($"Number {num1} should be greater than {num2}");
                return;
            }

            Console.WriteLine("Enter third number:");
            num3 = Console.ReadLine();

            if (Convert.ToSingle(num3) > Convert.ToSingle(num2) && Convert.ToSingle(num3) < Convert.ToSingle(num2))
            {
                Console.WriteLine($"Number {num3} is between {num1} and {num2}");
            }
            else if (Convert.ToSingle(num3) < Convert.ToSingle(num1))
            {
                Console.WriteLine($"Number {num3} is smaller than {num1}");
            }
            else if (Convert.ToSingle(num3) > Convert.ToSingle(num2))
            {
                Console.WriteLine($"Number {num3} is greater than {num1} and {num2}");
            }
            else if (Convert.ToSingle(num3) == Convert.ToSingle(num1))
            {
                Console.WriteLine($"Number {num3} is equal to {num1}");
            }
            else if (Convert.ToSingle(num3) == Convert.ToSingle(num2))
            {
                Console.WriteLine($"Number {num3} is equal to {num2}");
            }


        }
    }
}
