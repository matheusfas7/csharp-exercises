/* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
problema. */

using ex6;
using System.Globalization;

Aluno alu = new Aluno();

Console.Write("Nome do aluno: ");
alu.Nome = Console.ReadLine();

Console.Write("Digite a nota do 1º trimestre: ");
alu.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a nota do 2º trimestre: ");
alu.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a nota do 3º trimestre: ");
alu.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nota final = " + alu.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
if (alu.Aprovado()) {
    Console.WriteLine("APROVADO!");
} else {
    Console.WriteLine("REPROVADO!");
    Console.WriteLine("Faltaram " + alu.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos!");
}

