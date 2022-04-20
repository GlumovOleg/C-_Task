namespace ClassLib;
public class MyClass
{
    public static int Max(int a, int b)
    {
        if ( a > b) 
        return a;
        
        else
        {
            return b;
        }
    }

///<summary>
/// Получить массив с указанным размером
///</summary>
 public static int[] GetArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(10, 100);
        }
        return arr;
    }

///<summary>
/// Получить массив с указанным размером в заданном диапазоне
///</summary>
 public static int[] GetArray(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(minValue, maxValue);
        }
        return array;
    }

}
