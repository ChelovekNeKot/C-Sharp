//====================================================================== 
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// =====================================================================

// //Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int arrMin, int arrMax)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] arr = new int[num];
    //Тест границ
    if (arrMin < arrMax)
    {
        //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(arrMin, arrMax + 1);
        }
    }
    //Возвращаем результат
    return arr;
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

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int SumNeChetEl(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        count += arr[i];    
    }
    return count;
}

int SumNeChetIndex(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i = i + 1)
    {
        count += arr[i];    
    }
    return count;
}

int[] array = FillArray(10, -10, 10); //заполняем массив  = вызов метод массива(передаем параметры)
Print1DArray(array); // печать массива, чтобы увидеть, что всё правильно
Console.WriteLine();
int summa = SumNeChetEl(array);
int summa1 = SumNeChetIndex(array);

PrintResult($"Сумма элементов на нечётных позициях: {summa}"); // Выводим сумму элементов из нечетных позиций
Console.WriteLine();
PrintResult($"Сумма элементов на нечётных index: {summa1}"); // Выводим сумму элементов из нечетных index

