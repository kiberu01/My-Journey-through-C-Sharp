using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            string choice;

            Console.WriteLine("Welcome to the console Calculator");
            Console.WriteLine("Enter your first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your choice of operation???");
            Console.WriteLine(" + : Addition\n - : Subtraction\n * : Multiplication\n / : Division");

            choice = Console.ReadLine();

            if (choice == "+")
            {
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
            } else if (choice == "-")
            {
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
            } else if(choice == "*")
            {
                result = num1 * num2;   
                Console.WriteLine("Result: " + result);
            } else if (choice == "/")
            {
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Choice a valid operation");
            }

            Console.WriteLine("Thank you for using our calculator");
        }
    }
}
