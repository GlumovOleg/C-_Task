// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран.

using System;

int[] array = new int[8];
Console.Write("Массив чисел:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    // Что бы избежать массивов только из "0" и "1" присваиваем хотя бы по одному значению 1 и 0 :) 
    array[0] = 1;
    array[7] = 0;
    Console.Write($" {array[i]}");
}
