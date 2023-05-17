﻿using Interfaces.Entities;
using Interfaces.Services;
using System.Globalization;

Console.WriteLine("Enter rental data: ");
Console.Write("Car model: ");
string carModel = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Finish (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));
RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine();
Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);
