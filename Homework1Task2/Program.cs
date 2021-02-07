using System;

namespace Homework1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2;

            Console.WriteLine("Enter first number:");
            num1 = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            num2 = Console.ReadLine();

            if (Convert.ToInt16(num1) == 0 || Convert.ToInt16(num2) == 0)
            {
                Console.WriteLine($"Number {num1} and {num2} should be different than 0");
                return;
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"Number {num1} should be different {num2}");
                return;
            }

            int sum = Convert.ToInt16(num1) + Convert.ToInt16(num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

            if (Convert.ToInt16(num1) > Convert.ToInt16(num2))
            {
                int dif1 = Convert.ToInt16(num1) - Convert.ToInt16(num2);
                Console.WriteLine($"{num1} minus {num2} is {dif1}");

            }
            else
            {
                int dif2 = Convert.ToInt16(num2) - Convert.ToInt16(num1);
                Console.WriteLine($"{num2} minus {num1} is {dif2}");

            }

            int mult = Convert.ToInt16(num2) * Convert.ToInt16(num1);
            Console.WriteLine($"{num1} times {num2} is {mult}");


            if (Convert.ToInt16(num1) > Convert.ToInt16(num2))
            {
                int division1 = Convert.ToInt16(num1) / Convert.ToInt16(num2);


                Console.WriteLine($"{num1} divided by {num2} is {division1}");

            }
            else
            {
                int division2 = Convert.ToInt16(num2) / Convert.ToInt16(num1);


                Console.WriteLine($"{num2} divided by {num1} is {division2}");

            }

            if (Convert.ToInt16(num1) % Convert.ToInt16(num2) == 0 || Convert.ToInt16(num2) % Convert.ToInt16(num1) == 0)
            {
                Console.WriteLine($"The module of {num1} divided by {num2} is 0");
            }
            else if (Convert.ToInt16(num1) > Convert.ToInt16(num2))
            {

                int mod = Convert.ToInt16(num1) % Convert.ToInt16(num2);


                Console.WriteLine($"The module of {num1} divided by {num2} is {mod}");
            }
            else
            {

                int mod2 = Convert.ToInt16(num2) % Convert.ToInt16(num1);


                Console.WriteLine($"The module of {num2} divided by {num1} is {mod2}");
            }
        }
    }
}
