// =====================================================================================
// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// ======================================================================================

// Метод считывания данных пользователя 
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int CountNum(int numOfDigits)
{
    int result = 0;
    for (int i = 0; i < numOfDigits; i++)
    {
        int number = ReadData("Введите число: ");
        if (number > 0) result++;
    }
    return result;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numOfDigits = ReadData ("Введите любое количество чисел: ");
int quantity = CountNum(numOfDigits);

PrintResult($"Введенное количество цифр больше 0: {quantity}");