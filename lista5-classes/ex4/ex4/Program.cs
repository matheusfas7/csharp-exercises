/* Fazer um programa para ler os valores da largura e altura
de um retângulo. Em seguida, mostrar na tela o valor de
sua área, perímetro e diagonal. Usar uma classe como
mostrado no projeto ao lado. */

using ex4;
using System.Globalization;

Retangulo r = new Retangulo();
Console.Write("Qual a largura do retângulo? ");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Qual a altura do retângulo? ");
r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Área: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Perímetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));