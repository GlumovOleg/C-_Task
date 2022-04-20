// Найти сумму цифр числа.

Console.WriteLine("Введиете число: ");
int number = int.Parse(Console.ReadLine());

int Sum(int num)
{
    return num = num < 10 ? num: num % 10 + Sum(num / 10);
    // if (num < 10) return num;
    // else return num % 10 + Sum(num / 10);
}
Console.WriteLine(Sum(number).ToString());