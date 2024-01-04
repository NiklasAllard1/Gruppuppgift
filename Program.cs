using System;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }

        return (double)a / b;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello and welcome to the calculator!");
        Console.WriteLine("Press 1 for addition");
        Console.WriteLine("Press 2 for subtraction");
        Console.WriteLine("Press 3 for multiplication");
        Console.WriteLine("Press 4 for division");

        int choice = Convert.ToInt32(Console.ReadLine());

        Calculator calculator = new Calculator();

        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {calculator.Add(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"Result: {calculator.Subtract(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"Result: {calculator.Multiply(num1, num2)}");
                break;
            case 4:
                Console.WriteLine($"Result: {calculator.Divide(num1, num2)}");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
