/*Напишите программу, которая найдет точку пересечения двух прямых, заданных
уравнениями y = k1 * x + b1, y = k2 * x + b2. b1, k1, b2, k2 задаются пользователем.*/

void Main()
{
    Console.WriteLine("Введите значение k1");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b1");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k2");
    double k2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b2");
    double b2 = double.Parse(Console.ReadLine()!);
    FindIntersectionPoint(k1, b1, k2, b2);
}

void FindIntersectionPoint(double arg11, double arg12, double arg21, double arg22)
{
    double x = 0;
    double y = 0;
    if (arg11 == arg21)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (arg22 - arg12) / (arg11 - arg21);
        y = arg11 * x + arg12;
    }
    Console.WriteLine($"Точкой пересечения двух прямых является: x={x}, y={y}");
}

Main();