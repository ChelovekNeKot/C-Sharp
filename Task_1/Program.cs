//============================================================================================================
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//============================================================================================================

string? inputLineA = Console.ReadLine(); //Читаем данные пользователя
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null) //Проверка на отсутсвие значения. Предотвращение ошибки
{
    int inputNumberA = int.Parse(inputLineA); //Перевод строки в вещественное число
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine("Число A > B");
    }
    else
    {
        Console.WriteLine("Число B > A");
    }
}