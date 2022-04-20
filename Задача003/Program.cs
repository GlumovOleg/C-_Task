// По заданному номеру дня недели вывести его название

int a = int.Parse(Console.ReadLine());

if (a == 1) 
{
    Console.Write("Понедельник");
}

if (a == 2) 
{
    Console.Write("Вторник");
}    

if (a == 3) 
{
    Console.Write("Среда");
}    

if (a == 4) 
{
    Console.Write("Четвесрг");
}    

if (a == 5) 
{
    Console.Write("Пятница");
}    

if (a == 6) 
{
    Console.Write("Суббота");
}    

if (a == 7) 
{
    Console.Write("Воскресенье");
}
return;
{
    Console.WriteLine("Такого дня недели нет");
}