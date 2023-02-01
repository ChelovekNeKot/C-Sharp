// =====================================================================
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// =====================================================================

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

int SumMN(int M, int N)
{
    if (M >= N) return N;
    return M + SumMN(M + 1, N);
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

Console.Write("Сумма элементов в промежутке между числами: ");
PrintResult(M < N ? SumMN(M, N) :SumMN(N, M));