// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if ((x == 0) | (y == 0))
{
    Console.Write("Неверно введены данные");
    return;
}
if ((x > 0) & (y > 0))
{
    Console.Write("Первая четверть");
    return;
}
if ((x < 0) & (y > 0))
{
    Console.Write("Вторая четверть");
    return;
}


if ((x < 0) & (y < 0))
{
    Console.Write("Третья четверть");
    return;
}

if ((x > 0) & (y < 0))
{
    Console.Write("Четвертая четверть");
    return;
}
