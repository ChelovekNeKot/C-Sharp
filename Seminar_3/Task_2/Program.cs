// =============================================================
// Задача 2
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// // =============================================================


int ReadData(string line) // Чтение данных из консоли
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

double Calculate(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


int x1 = ReadData("Введите координату X1: ");
int x2 = ReadData("Введите координату X2: ");
int y1 = ReadData("Введите координату Y1: ");
int y2 = ReadData("Введите координату Y2: ");
int z1 = ReadData("Введите координату Z1: ");
int z2 = ReadData("Введите координату Z2: ");

double answer = Calculate(x1, x2, y1, y2, z1, z2);

PrintResult("Расстояние между точками: " +  Math.Round(answer, 2));