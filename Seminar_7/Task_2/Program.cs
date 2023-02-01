// ===========================================================================================
// Задача 50.Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том,
// что оно найдено или же указание, что такого элемента нет.
// ===========================================================================================

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
    // Создаём массив
    int[,] arr = new int[rows, cols];

    if (arrMin < arrMax)
    {
        // Заполняем массив
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

//Поиск элемента
void FindElement(int rows, int cols, int[,] arr, int number)
{
    string result = "Элемент не найден";
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (arr[i, j] == number)
            {
                result = "Элемент найден";
            }
        
        }
    }
    Console.WriteLine(result);
}


// Печать массива с выделением найденного элемента
void Print2DArrayColor(int number, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{arr[i, j]} \t");
                Console.ResetColor();
            }
            else { Console.Write($"{arr[i, j]} \t"); }
        }
        Console.WriteLine();
    }
}

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

int number = ReadData("Введите искомый элемент: ");


int[,] arr = Fill2DArray(rows, cols, 1, 9);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArrayColor(number, arr);
FindElement(rows, cols, arr, number);

// PrintResult("Искомый элемент: ", FindElement(rows, cols, arr, number).ToString());