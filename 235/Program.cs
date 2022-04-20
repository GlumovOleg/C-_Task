// // счастливый билетик 6 цифр

// Console.WriteLine("Введите номер билета: ");
// string num = Console.ReadLine();
// int f = 0;
// int f1 = 0;

// f = int.Parse(num[0].ToString() + num[1].ToString() + num[2].ToString());
// f1 = int.Parse(num[3].ToString() + num[4].ToString() + num[5].ToString());

// if (f == f1)
// {
//     Console.WriteLine("Билет счастливый");
// }








//  Реверс числа

// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(GetReversNumber(number));

// static int GetReversNumber(int num)
// {
//     if (num < 10) return num;
//     else
//     {
//         return int.Parse(num % 10 + GetReversNumber(num / 10).ToString());
//     }

// }

//123 4
//12 3
//1 2
// 1


// Возведение в степень, с учетом 0 степени


// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите степень числа: ");
// int stepen = int.Parse(Console.ReadLine());

// int GetStepenNumber(int num, int step)
// {
//     if (step == 1) return num;
//     else
//     {
//         return num *= GetStepenNumber(num, step - 1);
//     }   Console.WriteLine($"{num} в степени {step} - {GetStepenNumber(number, stepen)}");

// }

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);


