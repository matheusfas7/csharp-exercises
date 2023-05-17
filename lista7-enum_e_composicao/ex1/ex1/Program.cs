using System.Globalization;
using System.Collections.Generic;
using ex1.Entities;
using ex1.Entities.Enums;
using System.ComponentModel;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Client c1 = new Client(name, email, birthDate);


Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Order order = new Order(DateTime.Now, status, c1);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string pName = Console.ReadLine();
    Console.Write("Product price: ");
    double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int pQuantity = int.Parse(Console.ReadLine());
    Product product = new Product(pName, pPrice);
    OrderItem item = new OrderItem(pQuantity, product);
    order.AddItem(item);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMARY:");
Console.WriteLine(order);
