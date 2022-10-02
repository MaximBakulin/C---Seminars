Console.WriteLine("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[arrayLength];

for (int i = 0; i < userArray.Length; i++)
{
    userArray[i] = new Random().Next(100, 1000);
}

int getParityCheck(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

void getPrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

getPrintArray(userArray);
int count = getParityCheck(userArray);
Console.WriteLine($"В сформированном массиве четных чисел = {count}");