int getRandomNumberOfThreeDigit(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}
int getSecondDigitInRandomDigit(int digit)
{
    int secondDigit = digit / 10;
    secondDigit = secondDigit % 10;
    return secondDigit;
}
int randomDigit = getRandomNumberOfThreeDigit(100, 999);
int secondNumber = getSecondDigitInRandomDigit(randomDigit);
Console.WriteLine($"Случайное значение {randomDigit}");
Console.WriteLine($"Вторая цифра {secondNumber}");