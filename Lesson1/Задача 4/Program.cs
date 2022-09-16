Console.WriteLine("Введите первое число: ");
int FirstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondUserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int ThirdUserNumber = Convert.ToInt32(Console.ReadLine());
if (FirstUserNumber == SecondUserNumber)
{
    if (SecondUserNumber == ThirdUserNumber)
    {
        Console.WriteLine("Все числа одинаковые!");
        return;
    }
}
if (FirstUserNumber > SecondUserNumber)
{
    if (FirstUserNumber > ThirdUserNumber)
    {
        Console.WriteLine($"Первое число {FirstUserNumber} самое большое из введенных");
    }
    else
    {
        Console.WriteLine($"Третье число {ThirdUserNumber} самое большое из введенных");
    }
}
else
{
    if (SecondUserNumber > ThirdUserNumber)
    {
        Console.WriteLine($"Второе число {SecondUserNumber} самое большое из введенных");
    }
    else
    {
        Console.WriteLine($"Третье число {ThirdUserNumber} самое большое из введенных");
    }
}