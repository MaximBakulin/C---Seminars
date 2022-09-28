Console.WriteLine("Введите целое число, которое необходимо возвести в степень: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите степень, в которое необходимо возвести число {userNumber}");
int userDegree = Convert.ToInt32(Console.ReadLine());

int getExponentiation(int number, int degree)
{
    int tempNumber = number;
    for(int i = 1; i < degree; i++)
    {
        tempNumber = tempNumber * number;
    }
    return tempNumber;
}

if(userNumber == 0 || userDegree == 0)
{
    Console.WriteLine($"Число {userNumber} в степени {userDegree} = 1");
    Environment.Exit(0);
}

int result = getExponentiation(userNumber, userDegree);
Console.WriteLine($"Число {userNumber} в степени {userDegree} = {result}");