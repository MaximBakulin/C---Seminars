Console.WriteLine("Введите цифру от 1 до 7: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
int getChekNumberRange(int number)
{
    if(number > 7 || number < 1)
    {
        Console.WriteLine("Вы ввели цифру вне указанного диапазона!");
        Environment.Exit(0);
    }
    return number;
}
getChekNumberRange(UserNumber);
if(UserNumber > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}