// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] GenerateArray(int length)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}

void ShowArray(double[] arr)
{
    foreach (double item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

double FindMinMaxElement(double[] arr, bool value = true)
{
    double item = arr[0];
    foreach (double el in arr)
    {
        if (value)
        {
            if (item < el) // Ищем максимальное значение
            {
                item = el;
            }
        }
        else
        {
            if (item > el) // Ищем минимальное значение
            {
                item = el;
            }
        }
    }
    return item;
}

double[] array = GenerateArray(6);
ShowArray(array);
System.Console.WriteLine();
double min = FindMinMaxElement(array, false);
double max = FindMinMaxElement(array);
double result = Math.Round(max - min, 1);
System.Console.WriteLine($"Минимальный элемент массива {min}");
System.Console.WriteLine($"Минимальный элемент массива {max}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива {result}");




