// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
        Console.WriteLine($"{i} в кубе = {i * i * i}");
}