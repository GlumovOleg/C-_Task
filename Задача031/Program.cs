// Задать массив из 8 элементов и вывести их на экран
using System;

int[] array = new int[8];
int sum = 0;
Console.Write("Массив чисел:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write($" {array[i]}");
}