int userNumberOne = ConvertToInt("Введите первое значение: ");
int userNumberTwo = ConvertToInt("Введите второе значение: ");

int result = AckermanFunction(userNumberOne, userNumberTwo);
Console.WriteLine(result);

int AckermanFunction(int num1, int num2)
{
  if (num1 == 0)
    return num2 + 1;
  else
    if ((num1 != 0) && (num2 == 0))
      return AckermanFunction(num1 - 1, 1);
    else
      return AckermanFunction(num1 - 1, AckermanFunction(num1, num2 - 1));
}

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}