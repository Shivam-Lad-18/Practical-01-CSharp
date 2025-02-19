using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a console app for a calculator.");

            // Taking the input for the first number
            Console.Write("Enter your first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Taking the input for the second number
            Console.Write("Enter your second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Performing addition
            double sum = number1 + number2;
            Console.WriteLine($"The sum of given two numbers ({number1} and {number2}) is: {sum}");

            // Performing subtraction
            double subtraction = number1 - number2;
            Console.WriteLine($"The subtraction of given two numbers ({number1} and {number2}) is: {subtraction}");

            // Performing multiplication
            double multiply = number1 * number2;
            Console.WriteLine($"The multiplication of given two numbers ({number1} and {number2}) is: {multiply}");

            // Performing division with error handling to prevent division by zero
            try
            {
                double division = number1 / number2;
                Console.WriteLine($"The division of given two numbers ({number1} and {number2}) is: {division}");
            }
            catch
            {
                // Handling division by zero exception
                Console.WriteLine("Cannot divide by zero!");
            }
        }
    }
}
