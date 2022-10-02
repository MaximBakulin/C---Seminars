Console.WriteLine("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[arrayLength];

for (int i = 0; i < userArray.Length; i++)
{
    userArray[i] = new Random().Next(1, 101);
}

void getPrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getMaximumValueArray(int[] array)
{
    int maxValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue < array[i])
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

int getMinimumValueArray(int[] array)
{
    int minValue = getMaximumValueArray(array);
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue > array[i])
        {
            minValue = array[i];
        }
    }
    return minValue;
}

getPrintArray(userArray);
int min = getMinimumValueArray(userArray);
int max = getMaximumValueArray(userArray);
Console.WriteLine($"Минимальное значение {min}");
Console.WriteLine($"Максимальное значение {max}");
int differenceMaxMinValue = getMaximumValueArray(userArray) - getMinimumValueArray(userArray);
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {differenceMaxMinValue}");