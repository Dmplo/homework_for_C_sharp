// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = 4;
    int cols = 4;
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

void ShowArrayD2(int[,] array)
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

int[,] FindMinEl(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int max = array[i, k];
            for (int z = k; z < array.GetLength(1); z++)
            {
                if (array[i, z] > max)
                {
                    max = array[i, z];
                    int temp = array[i, k];
                    array[i, k] = max;
                    array[i, z] = temp;
                }
            }
        }
    }


    return array;
}

int[,] arr = CreateArr();
ShowArrayD2(arr);
System.Console.WriteLine();
ShowArrayD2(FindMinEl(arr));
