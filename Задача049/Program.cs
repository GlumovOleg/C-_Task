// Показать двумерный массив размером m×n, заполненный вещественными числами.
using System;

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
double[,] mas = new double[m, n];
Console.WriteLine();
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = new Random().NextDouble() * 10;
        Console.Write("{0,0:F2} ", mas[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();