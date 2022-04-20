// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[,] myArray = new int [m, n];
Console.WriteLine();
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void PoiskChisla(int[,] myArray, int num)
{
    int row = 0;
    int column = 0;
    int count = 0;
    
    for (int i = 0; i < myArray.GetLength(0); i++)
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (myArray[i, j] == num)
            {
                row = i;
                column = j;
                Console.Write($"({row} {column}) ");
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine($"Число {num} отсутствует в данном массиве.");
        }
}
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
PoiskChisla(myArray, num);



