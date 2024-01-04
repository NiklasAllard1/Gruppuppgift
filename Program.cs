using System;
using static System.Console;


static double add(double a, double b)
{
    return a+b;
}
static double sub(double a, double b)
{
    return a-b;
}
static double multi(double a, double b)
{
    return a*b;
}
static double divide(double a, double b)
{
    if(a == 0 || b == 0)
    {
        WriteLine("You can't divide something with nothing.");
        return 0;
    }
    return a/b;
}

double a, b;
string c;

    WriteLine("First number: ");
    while (!double.TryParse(ReadLine(), out a))
        {
            WriteLine("Invalid input. Please enter a valid number for the first number: ");
        }
    WriteLine("Second number: ");
    while (!double.TryParse(ReadLine(), out b))
        {
            WriteLine("Invalid input. Please enter a valid number for the second number: ");
        }
    while (true)
    {
    WriteLine("Choose one out of + - * / ");
    c = ReadLine();

    if(c == "+")
    {
        double result = add(a, b);
        WriteLine($" {a} + {b} = {result} ");
        break;
    }
    else if(c == "-")
    {
        double result = sub(a, b);
        WriteLine($" {a} - {b} = {result} ");
        break;
    }
    else if(c == "/")
    {
        double result = divide(a, b);
        WriteLine($" {a} / {b} = {result} ");
        break;
    }
    else if(c == "*")
    {
        double result = multi(a, b);
        WriteLine($" {a} * {b} = {result} ");
        break;
    }
    else
    {
        WriteLine("Error: Enter a valid operator.");
    }
    }