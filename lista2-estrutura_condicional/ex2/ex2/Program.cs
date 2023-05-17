// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"O número {num} é PAR!");
} else
{
    Console.WriteLine($"O número {num} é ÍMPAR!");
}