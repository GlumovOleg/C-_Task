// В двумерном массиве n×k заменить четные элементы на противоположные.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число K: ");
int k = int.Parse(Console.ReadLine());
int[,] table = new int[n, k];
int result = 0;

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(0); j++)
    {
        table[i, j] = new Random().Next(50);

        if ((i % 2 == 0) & (j % 2 == 0))
        {
            table[i, j] = table[i, j] * (-1);
        }
        Console.Write($" {table[i, j]} ");
    }
    Console.WriteLine();
}


