/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos ", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente. */

Console.Write("Digite o primeiro valor: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0 || b % a == 0) {
    Console.WriteLine($"Os números {a} e {b} são múltiplos!");
} else {
    Console.WriteLine($"Os números {a} e {b} não são múltiplos!");
}