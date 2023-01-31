using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.operators
{
    public class Operators
    {
        

        public static void Addition(double num1, double num2)
        {

            double result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }

        public static void Subtraction(double num1, double num2)
        {

            double result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
        }

        public static void Multiplication(double num1, double num2)
        {

            double result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
        }

        public static void Remainder(double num1, double num2)
        {

            double result = num1 % num2;
            Console.WriteLine($"{num1} % {num2} = {result}");
        }

        public static void Division(double num1, double num2)
        {

            double result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");

        }

    }
}
