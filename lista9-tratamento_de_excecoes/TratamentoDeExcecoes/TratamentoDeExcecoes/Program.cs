using System;
using System.IO;


try
{
    Console.Write("Enter the first value: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Enter the second value: ");
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero is not allowed");
}
catch (FormatException e)
{
    Console.WriteLine("Format error! " + e.Message);
}