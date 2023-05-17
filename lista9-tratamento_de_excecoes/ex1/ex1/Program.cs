﻿using ex1.Entities;
using ex1.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Enter account data:");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, balance, withdrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    acc.Withdraw(amountWithdraw);
    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
finally
{
    Console.WriteLine("Holder name: " + acc.Holder);
    Console.WriteLine("Account number: " + acc.Number);
}