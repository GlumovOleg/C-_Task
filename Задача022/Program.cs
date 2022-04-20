// Найти расстояние между точками в пространстве 2D/3D

Console.Write("Введите пространство (2D или 3D): ");
double prost = double.Parse(Console.ReadLine());

if (prost == 2)
{
    Console.Write("Введите координаты X1: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты X2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y: ");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y2: ");
    double y2 = double.Parse(Console.ReadLine());
    double distance = 0;
    Console.WriteLine();
    Console.WriteLine("2D пространство");
    distance = Math.Sqrt(
               Math.Pow(x2 - x, 2) + 
               Math.Pow(y2 - y, 2));
    Console.WriteLine($"Расстояние между точками = {distance}");
}
if (prost == 3)
{
    Console.Write("Введите координаты X1: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты X2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y: ");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y2: ");
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты Z: ");
    double z = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты Z2: ");
    double z2 = double.Parse(Console.ReadLine());
    double distance = 0;
    Console.WriteLine();
    Console.WriteLine("3D простоанство");
    distance = Math.Sqrt(
               Math.Pow(x2 - x, 2) + 
               Math.Pow(y2 - y, 2) + 
               Math.Pow(z2 - z, 2));
    Console.WriteLine($"Расстояние между точками = {distance}");
}