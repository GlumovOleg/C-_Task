// Найти третью цифру числа или сообщить, что её нет.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n <= 99)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
Console.Write("Третья цифра: ");
Console.WriteLine(n.ToString()[2]);
