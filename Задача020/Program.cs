// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());

if (a >= 5)
{
    Console.Write("Введен не корректный номер четверти");
    return;
}
if (a == 1)
{
    Console.Write("Координаты x > 0 и координаты y > 0");
}
if (a == 2)
{
    Console.Write("Координаты x < 0 и координаты y > 0");
}
if (a == 3)
{
    Console.Write("Координаты x < 0 и координаты y < 0");
}
if (a == 4)
{
    Console.Write("Координаты x > 0 и координаты y < 0");
}