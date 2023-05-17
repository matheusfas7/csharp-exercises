// Usando membros estáticos (static - não preciso criar objetos, já uso atributos e métodos a partir do nome da classe)

using ex7;
using System.Globalization;

Console.Write("Qual a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double resultado = ConversorDeMoeda.DolarEmReais(cotacao, dolar);
Console.WriteLine("Valor a ser pago em reais = R$" + resultado.ToString("F2", CultureInfo.InvariantCulture));