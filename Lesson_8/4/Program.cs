// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = 5;
    int cols = 5;
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 1);
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

int[,] Rotate90Array(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] result = new int[columns, rows];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = array[j, ((array.GetLength(1) - 1) - i)];
        }
    }
    return result;
}

int[,] FillArray(int[,] array)
{
    int side = 4;
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 1; k <= side; k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 0)
                {
                    array[i, j] = count++;
                }
            }
            array = Rotate90Array(array);
        }
    }
    return array;
}

int[,] array = CreateArr();
ShowArray(FillArray(array));



