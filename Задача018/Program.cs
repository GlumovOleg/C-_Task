// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Write("Введите 'true' или 'false' для значения X: ");
bool x = bool.Parse(Console.ReadLine());
Console.Write("Введите 'true' или 'false' для значения Y: ");
bool y = bool.Parse(Console.ReadLine());

if(!(x | y) == !x & !y)
{
    Console.WriteLine("Утверждение '¬(X ⋁ Y) = ¬X ⋀ ¬Y' истинно");
}
else
{
    Console.WriteLine("Утверждение '¬(X ⋁ Y) = ¬X ⋀ ¬Y' ложно");
}
