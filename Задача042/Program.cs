// Определить сколько чисел больше 0 введено с клавиатуры.
using System;

int count = 0;
string slovo = string.Empty;
do
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    if (n > 0)
        count++;
    Console.Write("Продолжить? ");
    slovo = Console.ReadLine();
}
while (slovo != "no");

Console.WriteLine($"Количество чисел больше 0 = {count}");












// for (int i = 0; i < nums; i++)
// {
//     Console.Write($"Введите число {i + 1}: ");
//     int n = int.Parse(Console.ReadLine());
//     if (n > 0)
//         count++;
// }

