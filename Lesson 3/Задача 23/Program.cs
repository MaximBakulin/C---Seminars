Console.WriteLine("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] arrayBasedOnUserNumber = new int[userNumber+1];

void cubeСalculation(int[] someArray)
{
  int countOne = 0;
  int length = someArray.Length;
  while (countOne <  length)
  {
    someArray[countOne] = Convert.ToInt32(Math.Pow(countOne, 3));
    countOne++;
  }
}

void resultOutput(int[] outputArray)
{
  int countTwo = outputArray.Length;
  int index = 0;
  while(index < countTwo)
  {
    Console.WriteLine($"куб числа {index} = {outputArray[index]}");
    index++;
  }
} 

cubeСalculation(arrayBasedOnUserNumber);
resultOutput(arrayBasedOnUserNumber);