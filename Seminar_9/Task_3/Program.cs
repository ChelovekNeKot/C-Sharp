// ===========================================
// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// ===========================================

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

int AccermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m != 0) return AccermanFunction(m - 1, 1);
    if (m < 0 || n < 0) return -1;
    return AccermanFunction(m - 1, AccermanFunction(m, n - 1));
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

PrintResult(AccermanFunction(m, n) == -1 ? "Оба числа должны быть положительными" : "A (m,n) = " + (AccermanFunction(m, n).ToString()));