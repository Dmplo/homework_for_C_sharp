// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Введите {i + 1}-e из {length} число > ");
    }
    return array;
}

int CalcPositiveElements(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item > 0)
        {
            count++;
        }
    }
    return count;
}

int length = new Random().Next(1, 10);
int[] array = FillArray(length);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше 0, которые ввел пользователь равно {CalcPositiveElements(array)}");
