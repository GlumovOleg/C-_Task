// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.WriteLine($"Число {number2} является квадраторм числа {number1} ");
    return;
}
if (number2 * number2 == number1)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2} ");
    return;
}
else
{
    Console.WriteLine($"Числa {number1} и {number2} не являются квадратом друг друга");
}