// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)

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

int[] GetRandomArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void ShowArray(int[] arr) {
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

int length = ReadInt("Введите длину массива");
int minValue = ReadInt("Введите минимальный порог случайных значений");
int maxValue = ReadInt("Введите максимальный порог случайных значений");
int[] array = GetRandomArray(length, minValue, maxValue);
ShowArray(array);