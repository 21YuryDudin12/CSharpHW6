//Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
 //b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэффициент k1 первой прямой");
double kx1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 первой прямой");
double bx1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 второй прямой");
double kx2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 второй прямой");
double bx2 = double.Parse(Console.ReadLine());

void FindDotCross (double k1, double b1, double k2, double b2)
{
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны, нет точки пересечения.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("(" + x + ";" + y + ")");
}
}

FindDotCross(kx1, bx1, kx2, bx2);