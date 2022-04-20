// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = new int [m, n];
int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
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
void PrintNewArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}
int[] SredArefm(int[,] array)
{
    int[] newArray = new int[array.GetLength(1)];
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[j, i];
        }
        newArray[i] = summ / array.GetLength(1);
        summ = 0;
    }
    return newArray;
}
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
PrintNewArr(SredArefm(myArray));