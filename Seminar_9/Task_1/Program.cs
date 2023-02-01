// ================================================================
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// ================================================================

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string LineGenRec(int numberN)
{
    //Точка остановки
    if (numberN == 0) return "";
    string outLine = numberN + " " + LineGenRec(numberN - 1);
    return outLine;
}

int numberN = ReadData("Введите число N: ");
string resultLine = LineGenRec(numberN);
PrintResult($"Натуральные числа от N до 1: {resultLine}");