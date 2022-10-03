Console.WriteLine("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[arrayLength];

for (int i = 0; i < userArray.Length; i++)
{
    userArray[i] = new Random().Next(1, 11);
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

void getMultiplicationPairsNumbersArray(int[] array)
{
    int lenght = array.Length;
    if (lenght % 2 == 0)
    {
        lenght = lenght / 2;
    }
    else
    {
        lenght = lenght / 2 + 1;
    }

    int count = array.Length - 1;
    int[] newArray = new int[lenght];

    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == count - i)
        {
            newArray[i] = array[i];
            break;
        }
        newArray[i] = array[i] * array[count - i];
    }
    getPrintArray(newArray);
}

getPrintArray(userArray);
getMultiplicationPairsNumbersArray(userArray);