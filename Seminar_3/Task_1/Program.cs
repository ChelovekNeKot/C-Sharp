// ========================================================================================================
// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// ========================================================================================================

void FirstVariant()
{
    int ReadData(string line) // Чтение данных из консоли
    {
        // Выводим сообщение
        Console.WriteLine(line);
        // Считываем число
        int number = int.Parse(Console.ReadLine() ?? "0");
        // Возвращаем значение
        return number;
    }

    bool TestPolin(int digit)
    {
        if ((digit / 10000 == digit % 10) && ((digit / 1000) % 10 == (digit / 10) % 10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void PrintResult(bool line)
    {
        Console.WriteLine(line);
    }


    int digit = ReadData("Введите палиндром: ");

    bool result = TestPolin(digit);

    PrintResult(result);
}
FirstVariant();

void SecondVariant()
{
    Console.WriteLine("Введите пятизначное число: ");

    string inputLine = Console.ReadLine() ?? ""; // Получение данных

    if (inputLine.Length == 5) // условие для вводимого числа
    {
        char[] charArray = inputLine.ToString().ToCharArray(); //Превращение в массив символов
        if (charArray[0] == charArray[4] && charArray[1] == charArray[3])
        {
            Console.WriteLine("Это палиндром");
        }
        else
        {
            Console.WriteLine("Это не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
    }
}
SecondVariant();

// void Dictionary() Не доделал!!!
// {
//     // использование словаря
// int ReadData(string line) // Чтение данных из консоли
// {
//     // Выводим сообщение
//     Console.WriteLine(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// Dictionary<int, int> GenerateDicPal()
// {
//     Dictionary<int, int> palindrom = new Dictionary<int, int>();

//     for (int i = 10; i < 100; i++)
//     {
//         int pal = ((i) * 100 + (i % 10) * 10 + i / 10);
//         palindrom.Add(pal,0);
//         Console.WriteLine(pal);

//     }
//     return palindrom;
// }

// bool TestPalinHash(int number, Dictionary<int, int> dict)
// {
//     if (dict.ContainsKey(number))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }

// }

// void PrintResult(bool line)
// {
//     Console.WriteLine(line);
// }


// int digit = ReadData("Введите палиндром: ");

// Dictionary<int,int> palindrom = GenerateDicPal();

// bool result = TestPalinHash(digit);//??

// PrintResult(result);
// }