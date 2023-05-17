/* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo. */

int alcool = 0;
int gasolina = 0;
int diesel = 0;

Console.WriteLine("Qual tipo de combustível você prefere? \nDigite 1 para Álcool \nDigite 2 para Gasolina " +
              "\nDigite 3 para Diesel \nDigite 4 para sair");

Console.WriteLine();
Console.Write("Digite aqui: ");
int opcao = int.Parse(Console.ReadLine());

while (opcao != 4)
{
    if (opcao == 1)
    {
        alcool += 1;
    } else if (opcao == 2)
    {
        gasolina += 1;
    } else if (opcao == 3)
    {
        diesel += 1;
    } else
    {
        Console.WriteLine("Código inválido!");
        Console.WriteLine();
    }

    Console.Write("Digite aqui: ");
    opcao = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Muito obrigado!");
Console.WriteLine($"Álcool: {alcool} \nGasolina: {gasolina} \nDiesel: {diesel}");
