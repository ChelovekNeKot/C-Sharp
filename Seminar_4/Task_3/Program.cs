// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран


// Вариант с заданным размером массива и диапозоном

void Variant1()
{
    void GenArray(int[] array) // Передача наименования массива
    {
        int length = array.Length; // получить длину массива
        int i = 0;
        while (i < length)
        {
            array[i] = new Random().Next(1, 10);  // получить новое случайное число от 1 до 10
            i++;
        }
    }

    void PrintArray(int[] array) //Распечатка массива
    {
        int count = array.Length;
        int i = 0;
        while (i < count - 1)
        {
            Console.Write(array[i] + ", ");
            i++;
        }
        Console.WriteLine(array[array.Length - 1]);
    }

    int[] array = new int[8]; // создать новый массив, в котором будет 8 элементов
    GenArray(array);
    PrintArray(array);
}
Variant1();

//Вариант с вводом данных о массиве с клавиатуры
void Variant2()
{
    int ReadData(string line)
    {
        Console.WriteLine(line);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    int[] GenArray(int arrayLen, int start, int stop)
    {
        Random rnd = new Random();
        int[] outarray = new int[arrayLen];
        for (int i = 0; i < arrayLen; i++)
        {
            outarray[i] = new Random().Next(start, stop);
        }
        return outarray;
    }
    void PrintArray(int[] array) //Распечатка массива
    {
        int count = array.Length;
        int i = 0;
        while (i < count - 1)
        {
            Console.Write(array[i] + ", ");
            i++;
        }
        Console.WriteLine(array[array.Length - 1]);// для удаления последней запятой
    }


    int arrayLen = ReadData("Введите длину массива: ");
    int start = ReadData("Введите начальный диапозон массива: ");
    int stop = ReadData("Введите конечный диапозон массива: ");

    int[] outarray = GenArray(arrayLen, start, stop);
    PrintArray(outarray);
}
Variant2();