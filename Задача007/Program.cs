// Показать числа от -N до N

Console.Write("Введите число -N: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int i = a;
while (i <= n)
{
    Console.WriteLine(i);
i++;
}