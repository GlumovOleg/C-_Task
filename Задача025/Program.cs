// Найти сумму чисел от 1 до А

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);