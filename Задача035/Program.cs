// Определить, присутствует ли в заданном массиве, некоторое число
using System;

int[] arr = new int[8];
int n = arr.Length;
int num = 3;
Console.Write($"Массив: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($" {arr[i]}");
}
for (int i = 0; i < arr.Length; i++)
    if (arr[i] == num)
    {
        Console.WriteLine();
        Console.WriteLine($"Число {num} присутствует в массиве!");
        return;
    }
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != num)
        Console.WriteLine();
        Console.WriteLine($"Число {num} отсутствует в массиве!");
        return;
}


// i = 0;
// while (i < n)
// {
//     if (arr[i] == find)
//     {
//         Console.WriteLine();
//         Console.WriteLine($"Число {find} присутствует в массиве ");
//         break;
//     }
//     i++;

//     if (arr[i] != find)
//     {
//         Console.WriteLine();
//         Console.WriteLine($"Число {find} отсутствует в массиве ");

//     }
//     i++;
// }
