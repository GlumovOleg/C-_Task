// Написать программу возведения числа А в целую стень B
using System;
Console.Clear();

Console.WriteLine("Введиете число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введиете степень B: ");
int b = int.Parse(Console.ReadLine());

int Stepen(int num, int step)
{
    return num = step == 1 ? num: num * Stepen(num, --step);
    // if (step == 1) return num;
    // else return num * Stepen(num, --step);
}
Console.WriteLine(Stepen(a, b).ToString());