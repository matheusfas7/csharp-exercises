/* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos. */

int a, b, soma;

Console.Write("Digite o primeiro valor: ");
a = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
b = int.Parse(Console.ReadLine());

soma = a + b;

Console.WriteLine($"{a} + {b} = {soma}");