// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int number = n % 10;

if (n < 100)
{
    Console.WriteLine("Ввели не верное число");
    return;
}
if (n > 999)
{
    Console.WriteLine("Ввели не верное число");
    return;
}
else
{
    Console.WriteLine($"Последняя цифра: - {number}");
}   
