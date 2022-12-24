// ===========================================================================
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// 456 -> 5
// 782 -> 8
// 918 -> 1
// ============================================================================

void FirstVariant() // Решение с помощью массива
{
    Console.WriteLine("Введите трезначное число: ");

    string inputLine = Console.ReadLine() ?? ""; // Получение данных

    if (inputLine.Length == 3) // условие для вводимого числа
    {
        char[] charArray = inputLine.ToString().ToCharArray(); //Превращение в массив символов
        Console.WriteLine(charArray[1]); // Вычисление, вывод результата
    }
    else
    {
        Console.WriteLine("Число не трёхзначное");
    }
}
FirstVariant();

void SecondVariant() // Решение с помощью остатка от деления
{
    Console.WriteLine("Введите трезначное число: ");

    string? inputLine = Console.ReadLine(); //проверка на пустое число, получение данных

    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine); // вещественное число
        if (inputNumber > 99 && inputNumber < 1000) // Получение данных
        {
            int secondSymbol = (inputNumber / 10) % 10; // Вычисление
            Console.Write(secondSymbol); // Вывод результата
        }
        else
        {
            Console.Write("УПС! Это не трёхзначное число");
        }
    }
}
SecondVariant();