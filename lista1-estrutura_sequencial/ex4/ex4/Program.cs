/*  Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais */

using System.Globalization;

Console.Write("Qual o número do funcionário? ");
int numeroFuncionario = int.Parse(Console.ReadLine());

Console.Write("Quantas horas esse funcionário trabalha por mês? ");
int horasTrabalhadas = int.Parse(Console.ReadLine());

Console.Write("Quantos reais esse funcionário recebe por hora? ");
double reais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salario = horasTrabalhadas * reais;

Console.WriteLine("Número do funcionário: " + numeroFuncionario + "\nSalário do funcionário: R$" + salario.ToString("F2", CultureInfo.InvariantCulture));