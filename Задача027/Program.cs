// Определить количество цифр в слове
using System;

Console.Write("Введите слово: ");
string s = Console.ReadLine();
int p = 0;
int count = 0;
for (int i = 0; i < s.Length; i++)
{
    if (int.TryParse(s[i].ToString(),out p)) count++;
    
}

Console.WriteLine($"Количество цифр в числе: {count} ");


        // static int IndexOfChar(string s)
        // {
        //     return s.IndexOf('1' );
        // }
        // static void Main(string[] args)
        // {
            
        //     string NewStr = Console.ReadLine();
        //     if (IndexOfChar(NewStr) == -1)
        //         Console.WriteLine("Строка не содержит цифр");
            
        //     else
        //         Console.WriteLine("Кол-во цифр в строке = {0}", IndexOfChar(NewStr));
        //     Console.ReadLine();
        // }
