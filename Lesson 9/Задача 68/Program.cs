int userNumberOne = ConvertToInt("Введите первое значение: ");
int userNumberTwo = ConvertToInt("Введите второе значение: ");

int res = AckermanFunction(userNumberOne, userNumberTwo);
Console.WriteLine(res);

int AckermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermanFunction(n - 1, 1);
    else
      return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}