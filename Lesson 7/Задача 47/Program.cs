Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillingArrayRandomNumbers(int numberLines, int numberColumns, int minValue, int maxValue)
{
    double[,] randomArray = new double[numberLines, numberColumns];
    for (int i = 0; i < numberLines; i++)
    {
        for (int j = 0; j < numberColumns; j++)
        {
            randomArray [i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
        }
    }
    return randomArray;
}

void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(data);
    Console.ResetColor();
}

void PrintArray(double [,] array)
{
    Console.Write(" \t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        PrintColorData(i + 1 + " \t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintColorData(i + 1 + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double [,] userArray = FillingArrayRandomNumbers(m, n, -100, 100);
PrintArray(userArray);

