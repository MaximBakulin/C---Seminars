Console.WriteLine("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber == 0)
{
    Console.WriteLine("Ноль - он и в Африке ноль, что тут считать?");
    Environment.Exit(0);
}

userNumber = Math.Abs(userNumber);

int getSumDigitsNumber(int number)
{
    int numberDigit = Convert.ToInt32(Math.Log10(number) + 1);
    int result = 0;
    int tempNumber = 0;
    for(int i = 0; i < numberDigit; i++)
    {
        tempNumber = number - number % 10;
        result = result + (number - tempNumber);
        number = number /10;
    }
    return result;
}

int sumDigitsUserNumber = getSumDigitsNumber(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} = {sumDigitsUserNumber}");