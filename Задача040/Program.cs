// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
using System;

double[] array = { 8.5, 17.4, 37.5, 8.5, 5.4, 25.2, 5.1 };
double minValue = array[0];
double maxValue = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxValue)
        maxValue = array[i];
    if (array[i] < minValue)
        minValue = array[i];
}
Console.WriteLine($"Разница между {maxValue} и {minValue} = {maxValue - minValue}");
