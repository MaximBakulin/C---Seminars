int userNumber = ConvertToInt("Введите значение: ");

AllValuesFromEnteredNumberToOne(userNumber);

void AllValuesFromEnteredNumberToOne(int number)
{
    if (number < 1)
    {
        return;
    }
    Console.Write($"{number} ");
    AllValuesFromEnteredNumberToOne(number - 1);
}

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}