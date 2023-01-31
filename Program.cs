using Methods.operators;
using System;

class Program
{
    public static void Main()
    {
        var operators = new Operators();
        double result1 = 0;
        double result2 = 0;
        string num1;
        string num2;
        string operate;
        string response;
        do
        {
            //NUM 1 INPUT AND CHECK


            do
            {
                Console.Write("please choose your first number: ");
                num1 = Console.ReadLine();


                if (!Double.TryParse(num1, out result1))
                {
                    Console.WriteLine("Try Again And Please Enter A Valid Number");
                }
            } while (!Double.TryParse(num1, out result1));

            //OPERATOR INPUT AND CHECK
            do
            {
                Console.Write("choose a valid Operator (+, -, *, %, /): ");
                operate = Console.ReadLine();

                if (operate != "+" && operate != "-" && operate != "*" && operate != "%" && operate != "/")
                    Console.WriteLine("PLEASE ENTER A VALID OPERATOR");
            } while (operate != "+" && operate != "-" && operate != "*" && operate != "%" && operate != "/");

            //NUM2 INPUT AND CHECK
            //THE OUTER DO WHILE LOOP IS TO PREVENT SYNTAX ERROR WHEN YOU TRY TO DIVIDE BY ZERO
            do
            {
                do
                {
                    Console.Write("Please Choose Your Second Number: ");
                    num2 = Console.ReadLine();

                     if (!Double.TryParse(num2, out result2))   // ***************TRY TO DEBUG THIS BY NOON******************
                    {
                        Console.WriteLine("Try Again And Please Enter A Valid Number.");
                    }
                      
                } while (!Double.TryParse(num2, out result2));
            } while (double.Parse(num2) == 0 && operate == "/");

            //OPERATION CONDITIONS********************************************************************

            if (operate == "+")
            {
                Operators.Addition(result1, result2);
            }
            else if (operate == "-")
            {
                Operators.Subtraction(result1, result2);
            }   
            else if (operate == "*")
            {
                Operators.Multiplication(result1, result2);
            }
            else if (operate == "/")
            {
                Operators.Division(result1, result2);
            }
            else
            {
                Operators.Remainder(result1, result2);
            }

            Console.WriteLine("Do you want to perform another operation? YES OR NO");
            response = Console.ReadLine().ToUpper();

            if (response == "YES")
                Console.WriteLine("THANK YOU FOR TRUSTING MY CACULATION");

        } while (response != "YES");

    }

   
}
