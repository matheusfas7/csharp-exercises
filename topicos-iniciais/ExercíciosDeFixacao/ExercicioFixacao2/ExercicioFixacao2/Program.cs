using System.Globalization;

Console.Write("Digite seu nome completo: ");
string nome = Console.ReadLine();

Console.Write("Quantos quartos tem na sua casa? ");
int quant = int.Parse(Console.ReadLine());

Console.Write("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Entre com seu último nome, idade e altura (mesma linha): ");
string[] vet = Console.ReadLine().Split(' ');
string lastName = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);

Console.WriteLine(nome);
Console.WriteLine(quant);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(lastName);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

