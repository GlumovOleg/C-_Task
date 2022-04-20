// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// using static System.Console;

int a1 = int.Parse(Console.ReadLine());

Console.WriteLine(GetAnswer(a1));

string GetAnswer(int a)
{
if ((a % 7 == 0) & (a % 23 == 0)) return ($"Число: {a1} кратно 7 и 23");
return "Не кратно 7 и 23";
    
}