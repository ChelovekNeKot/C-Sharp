// =====================================================
// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// =====================================================


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


int[,] UpdateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> Rows = new List<int>();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Rows.Add(arr[i, j]);
            Rows.Sort();
            Rows.Reverse();
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Rows[j];
        }
    }
    return arr;
}

int rows = 4;
int cols = 4;
int[,] arr = Fill2DArray(rows, cols, 1, 9);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(arr);
Console.WriteLine();

Console.WriteLine($"Отсортированный массив {rows}x{cols}:");
Print2DArray(UpdateArray(arr));