using System;

string strAns = "";
int coldTemp = 100;
int hotTemp = -100;
string coldCity = "";
string hotCity = "";
int sum = 0;
int count = 0;


do
{
    Console.WriteLine("Введите город и температуру через пробел");
    string strA = Console.ReadLine();
    string[] arr = strA.Split(" ");
    int tem = int.Parse(arr[1]);
    string City = arr[0];
    sum += tem;
    if(tem < coldTemp)
    {
        coldTemp = tem;
        coldCity = City;
    }
        if(tem > hotTemp)
    {
        hotTemp = tem;
        hotCity = City;
    }
    count++;

    Console.WriteLine("Продолжить? ");
    strAns = Console.ReadLine();


} while (strAns != "нет");

Console.WriteLine($"Тёплый город - {hotCity}");
Console.WriteLine($"Холодный город - {coldCity}");
Console.WriteLine($"Средняя температура {sum / count}");