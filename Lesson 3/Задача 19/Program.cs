void palindrom()
        {
        Console.Write("Введите пятизначное число: ");
        int userNumber = Convert.ToInt32(Console.ReadLine()); 
        int tempNumber1 = userNumber / 10000 % 10;
        int tempNumber2 = userNumber / 1000 % 10;
        int tempNumber3 = userNumber / 10 % 10;
        int tempNumber4 = userNumber % 10;
        int tempNumber5 = userNumber / 10000;
        
            if (tempNumber5 < 1 || tempNumber5 > 9)
            {
            Console.WriteLine($"ты точно уверен, что {userNumber} - это пятизначное число? Уверен? Если да, то иди повтори математику");
            }
            else if  (tempNumber1 == tempNumber4 && tempNumber2 == tempNumber3)
            {
            Console.WriteLine($"{userNumber} - число является палиндромом");
            }
            else{
            Console.WriteLine($"{userNumber} - число не является палиндромом");
            }
        }
        
palindrom();
