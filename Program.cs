﻿using System;

class Program
{
    public static void Main()
    {
        int result1 = 0;
        int result2 = 0;
        string num1;
        string num2;
        string operate;
        string response;
        //NUM 1 INPUT AND CHECK
        do
        {
            do
            {
                Console.Write("please choose your first number: ");
                num1 = Console.ReadLine();


                if (!int.TryParse(num1, out result1))
                {
                    Console.WriteLine("Try Again And Please Enter A Valid Number");
                }
            } while (!int.TryParse(num1, out result1));

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

                    if (int.Parse(num2) == 0 && operate == "/")
                    {
                        Console.WriteLine("THIS WILL PRODUCE A SYNTAX ERROR, USE A CORRECT INPUT");
                    }

                        if (!int.TryParse(num2, out result2))   // ***************TRY TO DEBUG THIS BY NOON******************
                    {
                        Console.WriteLine("Try Again And Please Enter A Valid Number. you did it before, i am warning you now. just dey play");
                    }
                } while (!int.TryParse(num2, out result2));
            } while (int.Parse(num2) == 0 && operate == "/");

            //OPERATION CONDITIONS********************************************************************

            if (operate == "+")
            {
                Addition(result1, result2);
            }
            else if (operate == "-")
            {
                Subtraction(result1, result2);
            }
            else if (operate == "*")
            {
                Multiplication(result1, result2);
            }
            else if (operate == "/")
            {
                Division(result1, result2);
            }
            else
            {
                Remainder(result1, result2);
            }

            Console.WriteLine("Done? YES OR NO");
            response = Console.ReadLine().ToUpper();
            if (response == "YES")
                Console.WriteLine("THANK YOU FOR BANKING WITH US, SEE YOU SOME OTHER TIME");
        } while (response != "YES");

    }

    // METHODS FOR MATHEMATICAL OPERATION
    public static void Addition( int num1, int num2)
    {

       int result = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result}"); 
    }

    public static void Subtraction(int num1, int num2)
    {

        int result = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result}");
    }

    public static void Multiplication(int num1, int num2)
    {

        int result = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {result}");
    }

    public static void Remainder(int num1, int num2)
    {

        int result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");
    }

     public static void Division( int num1, int num2)
    {

       int result = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result}"); 
        
    }
}
