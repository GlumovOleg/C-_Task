// Показать четные числа от 1 до N

int a = 1;
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}