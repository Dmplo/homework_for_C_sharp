// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    System.Console.Write(message);                      // Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool Validate3sign(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не 3-х значное число");
        return false;
    }

    return true;
}

int digit = ReadInt("Введите 3-хзначное число > ");
if (Validate3sign(digit))
{
    int middleDigit = digit / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {digit} равна {middleDigit}");
}

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Show3sign(int num)
{
    int value = 0;
    bool index = true;
    while (index)
    {
        if (num >= 100 && num < 1000)
        {
            value = num % 10;
            index = false;
        }
        num /= 10;
    }
    return value;
}

bool Check3sign(int value)
{
    if (value < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }

    return true;
}

int digitUser = ReadInt("Введите число: ");
if (Check3sign(digitUser))
{
    System.Console.WriteLine($"Третья цифра числа {digitUser} равняется {Show3sign(digitUser)}");
}

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
// ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string ShowTypeDay(int number)
{
    string mesage = "";
    if (number < 6)
    {
        mesage = "День является будним";
    }
    else
    {
        mesage = "День является выходным";
    }
    return mesage;
}

bool CheckDayNumber(int number)
{
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Введено некорректное значение");
        return false;
    }
    return true;
}

int dayOfWeek = ReadInt("Введите число, обозначающее порядковый дня недели: ");

if (CheckDayNumber(dayOfWeek))
{
    System.Console.WriteLine(ShowTypeDay(dayOfWeek));
}