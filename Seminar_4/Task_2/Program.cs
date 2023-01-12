//================================================
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе
//=================================================

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число: ");
int sum = SumDigit(number);
PrintResult("Сумма чисел: " + sum);