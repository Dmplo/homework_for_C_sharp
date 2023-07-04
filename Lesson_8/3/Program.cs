// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int[,] CreateArr(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
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

int[,] MatrixMultiplication(int[,] arrOne, int[,] arrTwo)
{
    int[,] result = new int[arrOne.GetLength(0), arrTwo.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < arrTwo.GetLength(0); k++)
            {
                result[i, j] += arrOne[i, k] * arrTwo[k, j];
            }
        }
    }
    return result;
}

int rows = ReadInt("Введите число строк");
int columns = ReadInt("Введите число столбцов");
int[,] firstArr = CreateArr(rows, columns);
int[,] secondArr = CreateArr(columns, rows);
System.Console.WriteLine("Первая матрица:");
ShowArray(firstArr);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
ShowArray(secondArr);
System.Console.WriteLine();
System.Console.WriteLine("Результат:");
int[,] result = MatrixMultiplication(firstArr, secondArr);
ShowArray(result);
