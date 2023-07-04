// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = rnd.Next(2, 5);
    int cols = rnd.Next(2, 5);
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

(int index, int result) FindMinSumRowEl(int[,] array)
{
    int index = -1;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (result > sum || i == 0)
        {
            index = i;
            result = sum;
        }
    }
    return (index, result);
}


int[,] array = CreateArr();
ShowArray(array);
(int index, int sum) = FindMinSumRowEl(array);
if (index == -1)
{
    System.Console.WriteLine("Error");
}
else
{
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов, равной {sum}: {index + 1} строка");
}
