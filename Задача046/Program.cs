// Написать программу масштабирования фигуры.
using System;
using System.Linq;
Console.Clear();

Console.WriteLine("Введите вершины (X1,Y1) (X2,Y2) (X3,Y3) (X4,Y4) через пробел: ");
string numbers = Console.ReadLine();
char[] separators = { ',', ' ', '(', ')' };
string[] num = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
int[] n = num.Select(int.Parse).ToArray();
Console.WriteLine("Введите коэффициент маштабирования K: ");
double k = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write($"({n[0] * k + "," + n[1] * k}) ");
Console.Write($"({n[2] * k + "," + n[3] * k}) ");
Console.Write($"({n[4] * k + "," + n[5] * k}) ");
Console.Write($"({n[6] * k + "," + n[7] * k})");