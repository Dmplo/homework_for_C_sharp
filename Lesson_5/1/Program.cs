// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int start = 100, int end = 999)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, end + 1);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

int CheckEvenNumbers(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GenerateArray(5);
ShowArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве равняется {CheckEvenNumbers(array)}");
