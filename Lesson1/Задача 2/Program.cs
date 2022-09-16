Console.WriteLine("Введите первое число: ");
int FirstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (отличное от первого): ");
int SecondUserNumber = Convert.ToInt32(Console.ReadLine());
if (FirstUserNumber == SecondUserNumber)
{
    Console.WriteLine("Вы ввели два одинаковых числа!");
    return;
}
if ((FirstUserNumber) > (SecondUserNumber))
{
    Console.WriteLine($"Первое число {FirstUserNumber} больше второго числа {SecondUserNumber}");
}
else
{
    Console.WriteLine($"Второе число {SecondUserNumber} больше первого числа {FirstUserNumber}");
}