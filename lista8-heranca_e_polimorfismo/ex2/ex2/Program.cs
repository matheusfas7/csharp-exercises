using ex2.Entities;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char pType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (pType == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, date));
    } 
    else if (pType == 'i') 
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach(Product produto in products)
{
    Console.WriteLine(produto.PriceTag());
}

