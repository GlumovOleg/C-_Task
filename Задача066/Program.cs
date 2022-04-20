// Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введиете число N: ");
int n = int.Parse(Console.ReadLine());

string Nat(int num, int carant)
{
    if (num == carant) return carant.ToString();
    else return carant.ToString() + Nat(num, ++carant);
}

Console.WriteLine(Nat(n, 1));
