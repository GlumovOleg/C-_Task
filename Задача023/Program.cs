// Показать таблицу квадратов чисел от 1 до N

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица квадратов: от 1 до N: ");
for (int i = 1 ; i <= n; i++)
{
    Console.WriteLine($"{i}*{i} = {i * i}");
}