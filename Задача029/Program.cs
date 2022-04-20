// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;
for (int i = 1; i <= n; i++)
{
    a *= i;
}
Console.WriteLine($"Произведение чисел {a}");