// Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int[] arr = new int[10];
int n = arr.Length;
int sum = 0;
Console.Write("Массив: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 20);
    Console.Write($"{arr[i]} ");
}
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечётных позициях {sum}");

