// Показать двумерный массив размером m×n заполненный целыми числами.

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int[,] table = new int[m, n];
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
Console.WriteLine();