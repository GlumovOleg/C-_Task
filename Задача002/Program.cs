// Даны два числа. Показать большее и меньшее число

String a = Console.ReadLine();
int number = int.Parse(a);

String b = Console.ReadLine();
int number_2 = int.Parse(b);

if (number > number_2)
{
    Console.WriteLine($"Наибольшее число - {number}");
}
else
{
    Console.WriteLine($"Наибольшее число - {number_2}");
}
if (number < number_2)
{
    Console.WriteLine($"Наименьшее число - {number}");
}
else
{
    Console.WriteLine($"Наименьшее число - {number_2}");
}