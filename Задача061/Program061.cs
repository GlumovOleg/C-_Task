// Найти произведение двух матриц.

using System;
Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = new int[m, n];
int[,] myArray2 = new int[m, n];
int[,] myArray3 = new int[m, n];

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ProizvidenieArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            arr3[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
}
Console.WriteLine();
Console.WriteLine("Матрица первая: ");
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Матрица вторая: ");
FillArray(myArray2);
PrintArray(myArray2);
Console.WriteLine();
ProizvidenieArray(myArray, myArray2, myArray3);
Console.WriteLine("Произведение первой матрицы на вторую: ");
PrintArray(myArray3);
