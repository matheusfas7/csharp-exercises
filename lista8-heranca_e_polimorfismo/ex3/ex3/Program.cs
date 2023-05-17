using ex3.Entities;
using System.Globalization;

List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        taxPayers.Add(new Individual(healthExpenditures, name, annualIncome));
    } else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        taxPayers.Add(new Company(numberOfEmployees, name, annualIncome));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach(TaxPayer taxPayer in taxPayers)
{
    Console.WriteLine($"{taxPayer.Name}: ${taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
}

double sum = 0;
foreach (TaxPayer taxPayer in taxPayers)
{
    sum += taxPayer.Tax();
}

Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");