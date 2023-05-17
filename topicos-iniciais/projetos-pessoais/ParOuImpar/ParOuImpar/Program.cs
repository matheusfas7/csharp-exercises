Console.Write("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

if (n1 % 2 == 0) {
    Console.WriteLine($"O número {n1} é PAR!");
} else {
    Console.WriteLine($"O número {n1} é ÍMPAR!");
}