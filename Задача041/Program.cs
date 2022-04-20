// Выяснить являются ли три числа сторонами треугольника.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if ((a + b > c) && (b + c > a) && (c + a > b))
{
    Console.WriteLine("Это треугольник");
}
else
{
    Console.WriteLine("Это не треугольник");
}