BeautifulDivider();
int arraySides = ConvertToInt("Введите длину стороны квадратного массива: ");
int[,] userArray = new int[arraySides, arraySides];

int num = 1;
int i = 0;
int j = 0;

while (num <= userArray.GetLength(0) * userArray.GetLength(1))
{
  userArray[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < userArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= userArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > userArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

BeautifulDivider();
PrintArray(userArray);
BeautifulDivider();

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void BeautifulDivider()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("********************************************");
    Console.ResetColor();
}