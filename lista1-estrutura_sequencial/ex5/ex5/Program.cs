/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */

using System.Globalization;

Console.Write("Digite o código da peça 1: ");
int peca1 = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de peças 1: ");
int qtdPeca1 = int.Parse(Console.ReadLine());

Console.Write("Digite o valor unitário de cada peça 1: ");
double valorPeca1= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Console.Write("Digite o código da peça 2: ");
int peca2 = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de peças 2: ");
int qtdPeca2 = int.Parse(Console.ReadLine());

Console.Write("Digite o valor unitário de cada peça 2: ");
double valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double valorTotal = qtdPeca1 * valorPeca1 + qtdPeca2 * valorPeca2;
Console.WriteLine();
Console.WriteLine("Valor a pagar: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));


