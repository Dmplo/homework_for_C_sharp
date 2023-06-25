// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


int[] GenerateArray(int length, int start = -10, int end = 10)
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

int GiveSumElements(int[] arr) {
    int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i == 0 || i % 2 != 1) {
        sum += arr[i];
    }
}
return sum;
}

int[] array = GenerateArray(4);
ShowArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве равняется {GiveSumElements(array)}");
