using System;
using static System.Console;


   class program
{




        static void Main(string[] args)
        {
            int choice = 0;
            startCalc(choice);
        }  


        static void startCalc(int choice)


        {
            WriteLine("Welcome to Calculator in C#");
           
            while(true)
            {
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }


            Console.Write("Enter the operator (+, -, *, /): ");
            string operation = Console.ReadLine();


            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }


            double result = 0;


            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter a valid operator.");
                    continue;
            }


                Console.WriteLine($"Result: {result}");


                Console.Write("Do you want to perform another calculation? (y/n): ");
                string continueCalculation = Console.ReadLine().ToLower();


                if (continueCalculation != "y")
                {
                    break;
                }
            }


        }


}


