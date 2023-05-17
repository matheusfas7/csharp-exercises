/*  Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */

Console.Write("Digite a coordenada x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Digite a coordenada y: ");
int y = int.Parse(Console.ReadLine());

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0) {
        Console.WriteLine("Primeiro quadrante");
    } else if (x > 0 && y < 0) {
        Console.WriteLine("Quarto quadrante");
    } else if (x < 0 && y < 0) {
        Console.WriteLine("Terceiro quadrante");
    } else {
        Console.WriteLine("Segundo quadrante");
    }
    Console.WriteLine();
    Console.Write("Digite a coordenada x: ");
    x = int.Parse(Console.ReadLine());
    Console.Write("Digite a coordenada y: ");
    y = int.Parse(Console.ReadLine());
}