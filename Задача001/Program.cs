// По двум заданным числам проверять является ли первое квадратом второго

string a = Console.ReadLine();
double number = double.Parse(a);
double count = Math.Sqrt(number);

string b = Console.ReadLine();
double number_2 = double.Parse(b);

if (count == number_2)
{
    Console.WriteLine($"Это число - {count}");
}
else
{
    Console.WriteLine("Число не является квадратом первого");
}