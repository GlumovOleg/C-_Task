// Показать числа Фибоначчи.

Console.Write("До какого числа считать число Фибаначчи? ");
int n = int.Parse(Console.ReadLine());
int result = 0;
int num = 1;
int num2 = 0;

Console.Write("Число Фибоначчи: ");

while(n > result)
{
    result = num + num2;
    num = num2;
    num2 = result;

    Console.Write(" " + result);
}