// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

using System;
Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = new int[m, n];

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 99);
        }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, min])
                {
                    min = k;
                }
            }
            int tmp = array[i, j];
            array[i, j] = array[i, min];
            array[i, min] = tmp;
        }
    }
    return array;
}

FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
PrintArray(SortArray(myArray));