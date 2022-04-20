// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[10];
int n = array.Length;
int result = 0;
Console.Write("Исходный ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write($"{array[i]} ");
}
for (int i = 0, j = n-1; i < (n / 2); i++)
{
    result = array[i] * array[j];
    Console.WriteLine($" {result} ");
}











//for (int i = 0, j = 0; i < J; j++, i++)
//{
//    k = (chisla[i] * chisla[i + 1]);
//    resultat[j] = k;
//    Console.WriteLine(resultat[j]);

//}
// for (var i = 1; i < J; i++)
// {
//     resultat[i - 1] = chisla[i - 1] * chisla[i];
//     Console.WriteLine(resultat[i - 1]);
// }