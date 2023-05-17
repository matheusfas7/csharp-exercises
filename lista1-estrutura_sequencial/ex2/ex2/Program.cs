/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos. 
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159 */

using System.Globalization;

double raio, area, pi;

Console.Write("Qual o valor do raio do círculo? ");
raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

pi = 3.14159;
area = pi * Math.Pow(raio, 2);

Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));