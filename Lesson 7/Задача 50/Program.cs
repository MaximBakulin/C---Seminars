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

void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}

void PrintArray(int [,] array)
{
    Console.Write(" \t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        PrintColorData(i + " \t");
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

int FindElementValueByPosition(int [,] array, int elementPosition)
{
    int variableWithDesiredNumber = 0;
    if (elementPosition > array.GetLength(0) * array.GetLength(1))
    {
        Console.WriteLine($"Элемента с порядковым номером {elementPosition} нет в данном массиве!");
        Environment.Exit(0);
    }
    else
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (elementPosition > array.GetLength(1) - 1)
            {
                elementPosition -= array.GetLength(1);
            }
            else
            {
                variableWithDesiredNumber = array [j, elementPosition];
                break;
            }
        }
    }
    return variableWithDesiredNumber;
}

int [,] userArray = FillingArrayRandomNumbers(userLines, userColumns, -100, 100);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Ваш массив:");
PrintArray(userArray);
Console.WriteLine("-----------------------------------------------------");

Console.WriteLine("Введите позицию элемента: ");
int userElementPosition = Convert.ToInt32(Console.ReadLine());

int ValueSearchedElement = FindElementValueByPosition(userArray, userElementPosition);
Console.WriteLine($"Значение элемента №{userElementPosition} в массиве: {ValueSearchedElement}");