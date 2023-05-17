// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

using System.Globalization;
using ex2;

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário: R$");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salário: R$");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (f1.Salario + f2.Salario) / 2;
Console.WriteLine("Salário médio: R$" + media.ToString("F2", CultureInfo.InvariantCulture));

