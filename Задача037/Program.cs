// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
int n = array.Length;
int min = 10;
int max = 99;
int count = 0;
Console.Write("Массив:");
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 300);
    Console.Write($" {array[i]}");
}
for (int i = 0; i < n; i++)
{
    if ((array[i] > min) & (array[i] < max))
    {
        count++;
    }
}
Console.WriteLine();
Console.Write($"Количество элементов из отрезка [10,99]: {count} ");






