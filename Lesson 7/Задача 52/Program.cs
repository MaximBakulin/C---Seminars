Console.WriteLine("Введите количество строк в массиве: ");
int userLines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

int [,] FillingArrayRandomNumbers(int numberLines, int numberColumns, int minValue, int maxValue)
{
    int [,] randomArray = new int [numberLines, numberColumns];
    for (int i = 0; i < numberLines; i++)
    {
        for (int j = 0; j < numberColumns; j++)
        {
            randomArray [i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return randomArray;
}

void PrintArray(int [,] array)
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

void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(data);
    Console.ResetColor();
}

void ArithmeticMeanArrayRow(int [,] array)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j, i];
        }
        average = Math.Round(average / array.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {average}");
        average = 0;
    }
}

int [,] userArray = FillingArrayRandomNumbers(userLines, userColumns, 0, 100);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t \t Ваш массив:");
PrintArray(userArray);
Console.WriteLine("************************************************************");
ArithmeticMeanArrayRow(userArray);