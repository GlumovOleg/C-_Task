// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// using static System.Console;

int a1 = 0;
int a2 = 0;
Console.WriteLine(!int.TryParse(Console.ReadLine(),out a1));
if (!int.TryParse(Console.ReadLine(),out a1))
{
    Console.WriteLine("Ошибка ввода числа");
    return;
}
if (!int.TryParse(Console.ReadLine(),out a2))
{
    Console.WriteLine("Ошибка ввода числа");
    return;
}

int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine(GetAnswer(a1, a2));

string GetAnswer(int a, int b);
    if (a % b == 0) return $"Число {a} кратно {b}";
    return (a % b).ToString();