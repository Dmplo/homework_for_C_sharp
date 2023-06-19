// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


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

bool ValidateZero(int num) {
    return num == 0;
}

int GiveExponentiation(int digit, int exp) {
    int exponentiation = 1;
    for (int i = 1; i <= exp; i++)
    {
        exponentiation *= digit;
    }
    return exponentiation;
}

int numberOne = ReadInt("Введите число А");
int numberTwo = ReadInt("Введите число В");

if (!ValidateZero(numberOne)) {
System.Console.WriteLine($"Число {numberOne} в степени {numberTwo} равно {GiveExponentiation(numberOne, numberTwo)}");
} else {
    System.Console.WriteLine("Число А должно быть не равно нулю!");
}


