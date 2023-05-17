// Ler um número inteiro N e calcular todos os seus divisores

Console.Write("Digite um valor inteiro: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n ; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}