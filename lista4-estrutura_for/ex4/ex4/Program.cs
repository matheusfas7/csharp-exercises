/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". */

using System.Globalization;

Console.Write("Quantos pares de números você quer ler? ");
int pares = int.Parse(Console.ReadLine());

for (int i = 1; i <= pares; i++)
{
    Console.Write("Qual é o numerador? ");
    double numerador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Qual é o denominador? ");
    double denominador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double divisao = numerador / denominador;
    if (denominador == 0)
    {
        Console.WriteLine("Divisão impossível!");
    } else
    {
        Console.WriteLine("Divisão: " + divisao.ToString("F1", CultureInfo.InvariantCulture);
    }
    Console.WriteLine();
}