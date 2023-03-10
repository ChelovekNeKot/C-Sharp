// ============================================================================
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа и
// ли сообщает, что третьей цифры нет. Берем числа до 100000

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// ============================================================================

Console.WriteLine("Введите число: ");

string inputLine = Console.ReadLine() ?? ""; // Получение данных

if (inputLine.Length >= 3) // условие для вводимого числа
{
    char[] charArray = inputLine.ToString().ToCharArray(); //Превращение в массив символов
    Console.WriteLine(charArray[2]); // Вычисление, вывод результата
}
else
{
    Console.WriteLine("Третьей цифры нет");
}