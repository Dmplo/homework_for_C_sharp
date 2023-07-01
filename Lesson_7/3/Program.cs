// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ShowAverageValues(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            System.Console.Write($"{array[i]:f1}\t");
    }
}

int[,] ReverseArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] result = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}

double[] CalcAverageArrRows(int[,] arr)
{
    double[] averageValuesArray = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        averageValuesArray[i] = (double) sum / arr.GetLength(1);
    }
    return averageValuesArray;
}

// int[,] array = new int[,] {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
// };
int[,] array = CreateArr();
ShowArray(array);
System.Console.WriteLine();
int[,] reverse = ReverseArray(array);
double[] averageValues = CalcAverageArrRows(reverse);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
ShowAverageValues(averageValues);