// ========================================================================================
//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// ========================================================================================

// Универсальный метод генерации и заполнение массива
int[] FillArray(int length,int arrMin, int arrMax)
{
    Random rand = new Random();   //Генератор случайных чисел
    int[] array = new int[length]; //Создаем массив
    for (int i = 0; i < array.Length; i++) //Заполняем массив
    {
        array[i] = rand.Next(arrMin, arrMax + 1);
    }
    return BubbbleSort(array);
}

// печатаем массив
void Print1DArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

int EvenNumberers(int[] arr)
{
    int count = 0;//переменная накопления
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i]))
        {
            count++;
        }
    }
    return count;
}

bool EvenTest(int count)
{
    return (count % 2 == 0);

}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] BubbbleSort(int[] array) // сортировка пузырьком, чтобы было "красиво"
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

int[] array = FillArray(10, 100, 999); //заполняем массив  = вызов метод массива(передаем параметры)
Print1DArray(array); // печать массива, чтобы увидеть, что всё правильно

int countEven = EvenNumberers(array);

PrintResult($"Количество чётных чисел в массиве: {countEven}");

