/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar. */

/* codigo   especificacao   preco  
    1       hotdog          4,00
    2       x-salada        4,50
    3       x-bacon         5,00
    4       Torrada         2,00
    5       Refri           1,50
 */

Console.Write("Digite o código do item (1 a 5): ");
int codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade que deseja: ");
int quant = int.Parse(Console.ReadLine());
double total = 0;

if (codigo == 1)
{
    total = 4 * quant;
} else if (codigo == 2)
{
    total = 4.5 * quant;
} else if (codigo == 3)
{
    total = 5 * quant;
} else if (codigo == 4)
{
    total = 2 * quant;
} else if (codigo == 5)
{
    total = 1.5 * quant;
} else
{
    Console.WriteLine("Código inválido!");
}

Console.WriteLine($"Total: R${total:F2}");

