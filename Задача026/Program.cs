// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень B: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
if (b > 0)
    for (int i = 1; i <= b; i++)
    {
        result *= a;
        Console.WriteLine($"Число {a} в степени {i} = {result}");
    }
else
{
    Console.WriteLine("Ввели не верную степень B ");
}