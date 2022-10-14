BeautifulDivider();
int axisValueX = ConvertToInt("Введите значение оси X: ");
int axisValueY = ConvertToInt("Введите значение оси Y: ");
int axisValueZ = ConvertToInt("Введите значение оси Z: ");
BeautifulDivider();

int[,,] userArray = new int[axisValueX, axisValueY, axisValueZ];
NewRandomArray(userArray);
PrintIndexArrayElements(userArray);
BeautifulDivider();

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintIndexArrayElements (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.WriteLine( $"{array[i,j,k]} ({i}, {j}, {k})");
      }
    }
  }
}

void NewRandomArray(int[,,] array)
{
  int[] num = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int number = 0;
  for (int i = 0; i < num.GetLength(0); i++)
  {
    num[i] = new Random().Next(10, 100);
    number = num[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (num[i] == num[j])
        {
          num[i] = new Random().Next(10, 100);
          j = 0;
          number = num[i];
        }
          number = num[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = num[count];
        count++;
      }
    }
  }
}

void BeautifulDivider()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("********************************************");
    Console.ResetColor();
}