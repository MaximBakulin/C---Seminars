int userNumberOne = ConvertToInt("Введите первое значение: ");
int userNumberTwo = ConvertToInt("Введите второе значение: ");

if (userNumberTwo < userNumberOne)
{
    Console.WriteLine("Второе число не может быть меньше первого!");
    Environment.Exit(0);
}

int userResult = SumAllNumbersInRange(userNumberOne, userNumberTwo);
Console.WriteLine(userResult);

int SumAllNumbersInRange(int numberOne, int numberTwo)
{
    if (numberOne > numberTwo)
    {
        return 0;
    }
    else
    {
    return numberOne + SumAllNumbersInRange(numberOne + 1, numberTwo);
    }
}

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}