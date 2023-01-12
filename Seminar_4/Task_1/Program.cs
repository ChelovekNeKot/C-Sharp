// ================================================================================
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// ================================================================================

int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(long line)
{
    Console.WriteLine(line);
}

long Pow(int numberA, int numberB)
{
    long result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");
long numberpow = Pow(numberA,numberB);
PrintResult(numberpow);