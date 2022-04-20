// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 99);
int a1 = a % 10;
int a2 = a / 10;
Console.WriteLine(a);
if ( a1 > a2)
{
    Console.WriteLine($"Наибольшая цифра числа: {a1}");
}
if (a1 < a2)
{
    Console.WriteLine($"Наибольшая цифра числа: {a2}");
}