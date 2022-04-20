// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"

using System;
Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string Nat(int num, int num2)
{
    if (num == num2) return num2.ToString();
    else return num2.ToString() + " " + Nat(num, ++num2);
}
Console.Write("Натуральные числа в промежутке от M до N: ");
Console.WriteLine(Nat(n, m));