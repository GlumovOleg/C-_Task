// Написать программу замену элементов массива на противоположные
using System;

int[] array = new int[15];
int n = array.Length;
int result = 0;
Console.Write("Old massive: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < n / 2; i++)
{
    result = array[i];
    array[i] = array[n - i - 1];
    array[n - i - 1] = result;
}
Console.WriteLine();
Console.Write($"New massive: ");
Console.Write(string.Join(" ", array));