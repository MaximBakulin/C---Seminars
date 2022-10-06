Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double resultX = (b2 - b1) / (k1 - k2);
double resultY = k1 * resultX + b1;
Console.WriteLine($"Точка пересечения двух прямых ({resultX} ; {resultY})");
