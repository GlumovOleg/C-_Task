//  В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

Console.WriteLine("Введите буквы: ");
string count = Console.ReadLine();

void Word(string our, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i < our.Length; i++)
    {
        word[length] = our[i];
        Word(our, word, length + 1);
    }
}
Word("аисв", new char[count]); 