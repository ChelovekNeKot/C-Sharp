// ====================================================================
// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// ====================================================================

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
            Console.Write($"{arr[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    {
        Console.WriteLine(line);
    }

}

int[,] Multiplic2DArr(int[,] arr1, int[,] arr2)
{
    int[,] array = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                array[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return array;
}

int i = ReadData("Введите количество строк 1-й матрицы: ");
int j = ReadData("Введите количество столбцов 1-й матрицы: ");
int[,] arr = Fill2DArray(i, j, 1, 9);

Console.WriteLine($"Случайный массив {i}x{j}:");
Print2DArray(arr);
Console.WriteLine();

PrintResult("Строки 2-й матрицы равняются столбцам 1-й");
Console.WriteLine();
int k = ReadData("Введите количество строк 2-й матрицы: ");
int[,] arr2 = Fill2DArray(j, k, 1, 9);

Console.WriteLine($"Случайный массив {j}x{k}:");
Print2DArray(arr2);
Console.WriteLine();

Print2DArray(Multiplic2DArr(arr, arr2));