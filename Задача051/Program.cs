// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int[,] massivA = new int[m, n];
Console.WriteLine();

for (int i = 0; i < massivA.GetLength(0); i++)
{
    for (int j = 0; j < massivA.GetLength(1); j++)
    {
        massivA[i, j] = i + j;
        Console.Write($"{massivA[i, j]} ");
    }
    Console.WriteLine();
}