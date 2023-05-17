Console.Write("How many rows? ");
int row = int.Parse(Console.ReadLine());
Console.Write("How many columns? "); 
int column = int.Parse(Console.ReadLine());

int[,] mat = new int[row, column];
for (int i = 0; i < row; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < column; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.Write("Which number do you want do check? ");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < row; ++i)
{
    for (int j = 0; j < column; j++)
    {
        if (mat[i, j] == num)
        {
            Console.WriteLine($"Position ({i}, {j})");
            if (j > 0) { Console.WriteLine($"Left: {mat[i, j - 1]}"); }
            if (j < column - 1) { Console.WriteLine($"Right: {mat[i, j + 1]}"); }
            if (i > 0) { Console.WriteLine($"Up: {mat[i - 1, j]}"); }
            if (i < row - 1) { Console.WriteLine($"Down: {mat[i + 1, j]}"); }
            Console.WriteLine();
        }
    }
}