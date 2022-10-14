int numberRowsFirstMatrix = ConvertToInt("Введите число строк матрицы №1: ");
int numberColumnsFirstMatrix = ConvertToInt("Введите число столбцов матрицы №1: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Число строк матрицы №2 равно количеству столбцов в матрице №1, то есть {numberColumnsFirstMatrix}");
Console.ResetColor();
int numberColumnsSecondMatrix = ConvertToInt("Введите число столбцов матрицы №2: ");
int valueRange = ConvertToInt("Верхняя граница значений в матрице: ");

int[,] firstMartrix = new int[numberRowsFirstMatrix,  numberColumnsFirstMatrix];
NewRandomArray(firstMartrix);
Console.WriteLine("Матрица №1:");
PrintArray(firstMartrix);
BeautifulDivider();

int[,] secondMartrix = new int[ numberColumnsFirstMatrix, numberColumnsSecondMatrix];
NewRandomArray(secondMartrix);
Console.WriteLine($"Матрица №2:");
PrintArray(secondMartrix);
BeautifulDivider();

int[,] resultMatrix = new int[numberRowsFirstMatrix,numberColumnsSecondMatrix];

MultiplyTwoMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintArray(resultMatrix);
BeautifulDivider();

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void NewRandomArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(valueRange);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyTwoMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void BeautifulDivider()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("********************************************");
    Console.ResetColor();
}
