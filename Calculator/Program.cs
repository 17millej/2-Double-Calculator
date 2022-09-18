using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your operator(+, -, * or /): ");
            string userOp = Console.ReadLine();

            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Calculator(num1, userOp, num2));

            Console.WriteLine("Calculation Complete!");

            Console.ReadLine();
        }
        static double Calculator(double num1, string userOp, double num2)
        {
            double result;

            if (userOp == "+")
            {
                result = num1 + num2;
            }
            else if (userOp == "-")
            {
                result = num1 - num2;
            }
            else if (userOp == "*")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            return result;
        }

    }
}
