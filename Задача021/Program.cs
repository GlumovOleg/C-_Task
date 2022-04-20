// Программа проверяет пятизначное число на палиндромом.


string array = Console.ReadLine();

if((array[0] == array[4]) & (array[1] == array[3]))
{
    Console.WriteLine("палиндромом");
}
else
{
    Console.WriteLine($"{array} не является палиндромом");
}