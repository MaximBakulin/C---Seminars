Console.WriteLine("Введите число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
if (UserNumber %2 == 0)
{
    Console.WriteLine($"Число {UserNumber} четное");
}
else
{
    Console.WriteLine($"Число {UserNumber} нечетное");
}
