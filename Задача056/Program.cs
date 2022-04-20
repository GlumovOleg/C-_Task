// Написать программу, которая обменивает элементы первой строки и последней строки.
using System;
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int[,] table = new int[m, n];
int temp = 0;

Console.Write("Old massive: ");
Console.WriteLine();

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(0); j++)
    {
        table[i, j] = new Random().Next(50);
        Console.Write($" {table[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("New massive: ");
Console.WriteLine();
for (int j = 0, i = 0; j < m; j++)
{
    temp = table[0, j];
    table[0, j] = table[n - 1, j];
    table[n - 1, j] = temp;
    Console.Write($" {table[i, j]} ");

}
Console.WriteLine();
