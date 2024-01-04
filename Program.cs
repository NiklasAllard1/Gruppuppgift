using System;
using System.Data;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Calculator");

        while(true)
        {
            Console.WriteLine("Enter an expression (ex. 1 + 2): ");
            string input = Console.ReadLine();

            try
            {
                double result = EvaluateException(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid expression. Error");
            }

            Console.WriteLine("Do you want to continue (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                break;
            }
        }
    }

    static double EvaluateException(string expression)
    {
        string[] elements = expression.Split(' ');
        double num1 = double.Parse(elements[0]);
        char op = char.Parse(elements[1]);
        double num2 = double.Parse(elements[2]);

        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return Division.Divide(num1, num2);
            default:
                throw new ArgumentException("Invalid operator.");
        }
    }
}

// Axels Funktion
public static class Division
{
    public static double Divide(double dividend, double divisor)
    {
        if (divisor != 0)
        {
            return dividend / divisor;
        }
        else 
        {
            throw new ArgumentException("Can't divide by 0");
        }

    }
}