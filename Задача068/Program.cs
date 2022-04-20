// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введиете число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введиете число N: ");
int n = int.Parse(Console.ReadLine());

string Nat(int num, int carant)
{
    if (num == carant) return carant.ToString();
    else return carant.ToString() + " " + Nat(num, ++carant);
}
Console.WriteLine(Nat(n, m));