// ==========================================================================================
// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ==========================================================================================

// Метод генерации и заполнения массива
double[,] Fill2DArray(int rows, int cols, int arrMin, int arrMax)
{
    // Создаём массив
    double[,] array2D = new double[rows, cols]; // [строка, столбец]
    // Заполняем массив
    if (arrMin < arrMax)
    {   
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
            }
        }
    }
    return array2D;
}

// Метод, печатает двумерный массив
void Print2DArray(double[,] arr)
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


int rows = 3; //строки
int cols = 4; //столбцы

double[,] array2D = Fill2DArray(rows, cols, -10, 10);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(array2D);