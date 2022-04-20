// В прямоугольной матрице найти строку с наименьшей суммой элементов.

using System;
Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = new int[m, n];

if(m == n)
{
    Console.WriteLine("Матрица не прямоугольная!");
    return;
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
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

int SumStrok(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += matr[i, j];
                minSum += matr[i, j]; 
            }
            else sum += matr[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}

Console.WriteLine();
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов №: {SumStrok(myArray)}");
Console.WriteLine();