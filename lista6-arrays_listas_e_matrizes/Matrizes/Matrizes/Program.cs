﻿Console.Write("Qual a ordem da matriz? ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.WriteLine("Main diagonal: ");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

int count = 0;
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0) { 
            count++;
            list.Add(mat[i, j]);
        }
    }
}
Console.WriteLine("Negative numbers: " + count);
foreach (int num in list)
{
    Console.WriteLine(num);
}