Console.WriteLine("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}

void OutputArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

OutputArray(array);