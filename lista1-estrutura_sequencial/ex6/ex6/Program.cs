/* 
Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/

using System.Globalization;
double pi = 3.14159;

Console.Write("Valor de A: ");
double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Valor de B: ");
double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Valor de C: ");
double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaTriangulo = (a * c) / 2;
double areaCirculo = pi * Math.Pow(c, 2);
double areaTrapezio = ((a + b) * c) / 2;
double areaQuadrado = Math.Pow(b, 2);
double areaRetangulo = a * b;

Console.WriteLine("Triângulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Circulo: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Trapézio: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Retangulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));