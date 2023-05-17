﻿/* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo. */

Console.Write("Quantas linhas você deseja? ");
int linhas = int.Parse(Console.ReadLine());

for (int i = 1; i <= linhas; i++)
{
    Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
}