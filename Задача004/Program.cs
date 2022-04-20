// Найти максимальное из трех чисел

Console.WriteLine("Введите числа: ");
String a = Console.ReadLine();
int number = int.Parse(a);

String b = Console.ReadLine();
int number2 = int.Parse(b);

String c = Console.ReadLine();
int number3 = int.Parse(c);

int max = number;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
{
    Console.Write("Максимальное число: ");
    Console.Write(max);
}