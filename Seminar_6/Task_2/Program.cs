// =======================================================================================================================
//№43 Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
// =======================================================================================================================

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

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// Вывод массива в консоль
void Print1DArray(int[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

// сортировка пузырьком
int[] BubbleSort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

int inputN = ReadData("Введите длину массива: ");
int[] array = GenArray(inputN, 0, 100);
Console.Write("Сгенерированный массив: ");
Print1DArray(array);
int[] bubble = BubbleSort(array);
Console.Write("Отсортированный массив: ");
Print1DArray(bubble);


