// ===================================================================
// Задача 2: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// ===================================================================
Console.WriteLine("Введите число А: ");
string inputLineA = Console.ReadLine() ?? ""; //Читаем данные пользователя
Console.WriteLine(string.Empty);
Console.WriteLine("Введите число B: ");
string inputLineB = Console.ReadLine() ?? "";//Проверка на отсутсвие значения. Предотвращение ошибки знаки:(??"")
Console.WriteLine(string.Empty);
Console.WriteLine("Введите число C: ");
string inputLineC = Console.ReadLine() ?? "";
Console.WriteLine(string.Empty);

int A = int.Parse(inputLineA); //Перевод строки в вещественное число
int B = int.Parse(inputLineB);
int C = int.Parse(inputLineC);


if (A > B) //(inputNumberA > inputNumberB && inputNumberA > inputNumberC ) ?
{
    if (A > C)

        Console.WriteLine("Max A");
    else
        Console.WriteLine("Max C");
}

else
{
    if (B > C)

        Console.WriteLine("Max B");
    else
        Console.WriteLine("Max C");
}

int max = 0;

int D = Math.Max(A, B);
int finallymax = Math.Max(max, C);
Console.WriteLine($"Максимальное число {finallymax}");