using ex8;
using System.Globalization;


Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
string resposta = Console.ReadLine();
double depositoInicial, saldo = 0.0;

if (resposta == "s" || resposta == "S")
{
    Console.Write("Entre o valor de depósito inicial: ");
    depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    saldo += depositoInicial;
}

ContaBancaria conta = new ContaBancaria(numero, titular, saldo);

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Depositar(deposito);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Sacar(saque);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
