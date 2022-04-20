// Написать программу преобразования десятичного числа в двоичное

Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());
string ostatok = string.Empty;
while (1 <= number)
{
    ostatok = (number % 2).ToString() + ostatok;
    number /= 2;
}
Console.Write(ostatok);