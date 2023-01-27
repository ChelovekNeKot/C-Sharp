// ===============================================================================================
// № 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// ===============================================================================================

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
int[,,] Fill3DArray(int rows, int cols, int depth, int arrMin, int arrMax)
{
    int[,,] arr = new int[rows, cols, depth];

    if (arrMin < arrMax)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < depth; k++)

                {
                    arr[i, j, k] = new Random().Next(arrMin, arrMax + 1);
                }
            }
        }
    }
    return arr;
}

// Метод, печатает трёхмерный массив
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) \t ");
            }
            Console.WriteLine();
        }
    }
}


int rows = ReadData("Введите число X: ");
int cols = ReadData("Введите число Y: ");
int depth = ReadData("Введите число Z: ");
int[,,] arr = Fill3DArray(rows, cols, depth, 10, 99);

Console.WriteLine($"Случайный массив {rows}x{cols}x{depth}:");
Print3DArray(arr);
