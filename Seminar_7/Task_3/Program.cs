// ==========================================================================================
// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// ==========================================================================================

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

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, печатает одномерный массив
void Print1DArray(double[] arr)
{
    string arrString = String.Empty;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }

    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

// Метод, печатает двумерный массив
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int arrMin, int arrMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols]; // [строка, столбец]

    if (arrMin < arrMax)
    {   // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(arrMin, arrMax + 1);
            }
        }
    }
    return array2D;
}


// Метод, принимает двумерный массив, возвращает одномерный массив 
double[] Count(int[,] arr)
{
    // Создаём новый одномерный массив
    double[] averageNum = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            averageNum[j] += arr[i, j];
        }
    }

    return Average(averageNum, arr.GetLength(0));
}

// Находим среднее арифметическое
double[] Average(double[] arr, int numbers)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = (arr[k] / ((double)arr.GetLength(0)));
    }
    return arr;
}

int rows = ReadData("Введите количество столбцов : ");
int cols = ReadData("Введите количество строк : ");
int[,] array2D = Fill2DArray(rows, cols, 10, 99);
Console.WriteLine();

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(array2D);
Console.WriteLine();

PrintResult($"Cредние арифметические по столбцам:");
Print1DArray(Count(array2D));