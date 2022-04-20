// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива.

int[] array = new int[12];
int sumP = 0;
int sumO = 0;
Console.Write("Массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,9);
    if(array[i] > 0)
    {
        sumP += array[i];
    }
    if(array[i]<0)
    {
        sumO += array[i];
    }
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов: {sumP}");
Console.WriteLine($"Сумма отрицательных элементов: {sumO}");