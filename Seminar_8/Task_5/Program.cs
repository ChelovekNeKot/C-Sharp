// ==================================================================
// № 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// ==================================================================

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

int[,] FillSpirallyArray(int row, int col)
{
    //С помощью переменной count задаются числа внутри массива начиная с 1
    int count = 1;
    //Объявляем и инициализируем массив.
    int[,] array = new int[row, col];

    //задаем точки начала и конца прямоугольника массива
    int startRow = 0;
    int endRow = row - 1;
    int startCol = 0;
    int endCol = col - 1;

    int maxValue = row * col;

    while (count < maxValue)
    {
        //движемся вправо
        for (int i = startCol; i <= endCol; i++)
        {
            array[startRow, i] = count++;
        }
        // сдвигаем крайнюю верхнюю точку к центру;
        startRow++;

        for (int j = startRow; j <= endRow; j++)
        {
            array[j, endCol] = count++;
        }

        //сдвигаем крайнюю правую точку
        endCol--;

        //движемся влево

        for (int i = endCol; i>=startCol; i--)
        {
            array[endRow,i] = count++;
        }
        // сдвигаем нижнюю границу к центру;
        endRow--;

        //движемся вверх
        for( int j = endRow; j>=startRow; j--)
        {
            array[j,startCol] = count++;
        }
        //сдвигаем левую границу
        startCol++;
    }
    return array;
}

int row = 4;
int col = 4;
int[,]spirall = FillSpirallyArray(row,col);
Print2DArray(spirall);
