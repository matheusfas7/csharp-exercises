Console.WriteLine("--Bem vindo ao Jokenpô!--");
Console.WriteLine();
Console.WriteLine("Digite 1 para PEDRA \nDigite 2 para PAPEL \nDigite 3 para TESOURA");
Console.WriteLine();

Console.Write("Digite aqui: ");
int jogador = int.Parse(Console.ReadLine());
Console.WriteLine();

switch (jogador)
{
    case 1:
        Console.WriteLine("Você jogou PEDRA!");
        break;
    case 2:
        Console.WriteLine("Você jogou PAPEL!");
        break;
    case 3:
        Console.WriteLine("Você jogou TESOURA!");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

Random numAleatorio = new Random();
int bot = numAleatorio.Next(1, 4);
if (bot == 1) {
    Console.WriteLine("Bot jogou PEDRA!");
}
else if (bot == 2) {
    Console.WriteLine("Bot jogou PAPEL!");
}
else {
    Console.WriteLine("Bot jogou TESOURA!");
}

if (jogador == 1 && bot == 1 || jogador == 2 & bot == 2 || jogador == 3 && bot == 3)
{
    Console.WriteLine("EMPATE!");
} else if (jogador == 1 && bot == 2 || jogador == 2 && bot == 3 || jogador == 3 && bot == 1)
{
    Console.WriteLine("Você perdeu!");
} else
{
    Console.WriteLine("Você ganhou!");
}