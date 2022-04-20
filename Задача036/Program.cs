// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел.

int[] array = new int[10];
int n = array.Length;
int countChet = 0;
int countNechet = 0;
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) countChet++;
    else countNechet++;
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел:  {countChet}");
Console.WriteLine($"Количество не чётных чисел:  {countNechet}");