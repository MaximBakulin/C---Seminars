Console.WriteLine("Сколько чисел будем вводить: ");
int numberUserNumbers = Convert.ToInt32(Console.ReadLine());

int[] FillingArrayUserNumbers(int lenghtArray)
{
    int[] resultArray = new int[lenghtArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        resultArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    Console.Write("Ваши числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("*********************************");
}

int CheckingNumberGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] userArray = FillingArrayUserNumbers(numberUserNumbers);
PrintArray(userArray);
int resultCount = CheckingNumberGreaterZero(userArray);
Console.WriteLine($"Количество чисел больше нуля - {resultCount}");