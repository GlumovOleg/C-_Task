// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
using System;
Console.Clear();

Console.Write("Введите чило A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите чило В: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество чисел в последовательности: ");
int count = int.Parse(Console.ReadLine());

string Method(int a, int b, int c)
{
    return c == 0 ? $"{(a+b).ToString()}" : $"{(a+b).ToString()} {Method(b, a+b, c-1)} ";
}
Console.WriteLine(Method(num1, num2, count-1));