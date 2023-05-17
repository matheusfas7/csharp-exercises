/* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1. */

Console.Write("Digite um valor: ");
int n = int.Parse(Console.ReadLine());

int fatorial = 1;
for (int i = 1;i <= n; i++)
{
    fatorial = fatorial * i;
}
Console.WriteLine(fatorial);