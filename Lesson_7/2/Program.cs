// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 2, 1 -> 4


int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = rnd.Next(2, 7);
    int cols = rnd.Next(2, 7);
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");

        }
        System.Console.WriteLine();
    }
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[,] array = CreateArr();
ShowArray(array);
System.Console.WriteLine("Ищу позицию элемента в двумерном массиве");
int userRow = ReadInt("Введите номер строки");
int userColumn = ReadInt("Введите номер столбца");
if (array.GetLength(0) >= userRow && array.GetLength(1) >= userColumn)
{
    System.Console.WriteLine($"Значение элемента {array[userRow, userColumn]}");
}
else
{
    System.Console.WriteLine("Такого элемента в массиве нет");
}
