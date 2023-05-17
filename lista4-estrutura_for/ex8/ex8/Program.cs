// Crie uma tabuada usando ForEach e Array

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.Write("Enter a value to see its multiplication table: ");
int escolha = int.Parse(Console.ReadLine());
foreach (int num in numbers)
{
    Console.WriteLine($"{escolha} x {num} = {escolha * num} ");
}
