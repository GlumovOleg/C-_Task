// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
string ss = Console.ReadLine();
Console.Write("Новое число: ");
Console.WriteLine(int.Parse(ss[0].ToString() + ss[2].ToString()));
Console.Write("Удалена цифра: ");
Console.WriteLine(int.Parse(ss[1].ToString()));
