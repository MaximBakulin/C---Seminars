Console.WriteLine("Введите число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
if(UserNumber < 100)
{
    Console.WriteLine("Третьей цифры нет");
    Environment.Exit(0);
}
int getReverseUserNumber(int number)
{
    string s = number.ToString();
    char[] ar = s.ToCharArray();
    Array.Reverse(ar);
    s = new String(ar);
    number = Convert.ToInt32(s);
    return number;
}
int getThirdDigitOfUserNumber(int number)
{
    int thirdNumber = number / 100;
    thirdNumber = thirdNumber % 10;
    Console.WriteLine($"Третья цифра {thirdNumber}");
    return thirdNumber;
}
int newNumber = getReverseUserNumber(UserNumber);
getThirdDigitOfUserNumber(newNumber);