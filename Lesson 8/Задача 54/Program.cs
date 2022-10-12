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

void DescendingSort(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m + 1];
                    array[i, m + 1] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
}

int [,] userArray = FillingArrayRandomNumbers(userLines, userColumns, 0, 10);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Исходный массив:");
PrintArray(userArray);
DescendingSort(userArray);
Console.WriteLine();
Console.WriteLine("**************************************************");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Отсортированный массив:");
PrintArray(userArray);