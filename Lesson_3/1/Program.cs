// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int GetPalyndrom(int userNumber)
{
    int number = 0;
    while (userNumber > 0)
    {
        int i = userNumber % 10;
        number = number * 10 + i;
        userNumber /= 10;
    }
    return number;
}
bool ValidatePalyndrom(int valueOne, int valueTwo)
{
    if (valueOne == valueTwo) return true;
    return false;
}

int userNumber = Prompt("Введите число");
int palyndrom = GetPalyndrom(userNumber);
if (ValidatePalyndrom(userNumber, palyndrom)) System.Console.WriteLine($"Число {userNumber} палиндром");   
else System.Console.WriteLine($"Число {userNumber} не палиндром");   

