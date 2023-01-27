// ==================================================================================
// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// ==================================================================================

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

int[,] arr = Fill2DArray(rows, cols, 1, 9);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(arr);
Console.WriteLine();

int minRow = FindMinRow(arr);

PrintResult("Строка с наименьшей суммой элементов:" + minRow);

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

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int arrMin, int arrMax)
{
    int[,] arr = new int[rows, cols];

    if (arrMin < arrMax)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = new Random().Next(arrMin, arrMax + 1);
            }
        }
    }
    return arr;
}

// Метод, печатает двумерный массив
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    if (rows == cols)
    {
        Console.WriteLine($"Массив должен быть прямоугольный!");
    }
    else Console.WriteLine(line);
}

//Находим строку с минимальной суммой элементов
int FindMinRow(int[,] arr)
{
    int outIndexRow = -1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i + 1;
        }
        sum = 0;
    }
    return outIndexRow;
}