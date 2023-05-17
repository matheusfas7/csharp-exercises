// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

Console.Write("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());

if (num >= 0) {
    Console.WriteLine($"O número {num} é POSITIVO!");
} else {
    Console.WriteLine($"O número {num} é NEGATIVO!");
}