/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

Console.Write("Digite o primeiro valor: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
int c = int.Parse(Console.ReadLine());

Console.Write("Digite o quarto valor: ");
int d = int.Parse(Console.ReadLine());

int diferenca = (a * b) - (c * d);
Console.WriteLine($"Diferença: {diferenca}");
