/* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5. */

using System.Globalization;

Console.Write("Quantos testes você quer fazer? ");
int teste = int.Parse(Console.ReadLine());

for (int i = 1; i < teste; i++)
{
    Console.Write($"Digite o valor: ");
    string[] valor = Console.ReadLine().Split(' ');
    double valor1 = double.Parse(valor[0], CultureInfo.InvariantCulture);
    double valor2 = double.Parse(valor[1], CultureInfo.InvariantCulture);
    double valor3 = double.Parse(valor[2], CultureInfo.InvariantCulture);
    double mediaPond = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / (10.0);

    Console.WriteLine(mediaPond.ToString("F1", CultureInfo.InvariantCulture));
}

