// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

using System;
Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
// if (n < m)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.Write("Сумма натуральных чисел от M до N: ");
Console.WriteLine(Sum(m, n));