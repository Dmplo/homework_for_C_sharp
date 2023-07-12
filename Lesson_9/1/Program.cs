// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string message)
{
    System.Console.Write(message);                      
    int number = Convert.ToInt32(Console.ReadLine());  
    return number;                                     
}


void ShowEvenNumbers(int numOne, int numTwo)
{
    if (numOne % 2 == 0) System.Console.WriteLine(numOne);
    if (numOne == numTwo) return;
    ShowEvenNumbers(numOne + 1, numTwo);
}

int numOne = ReadInt("Введите первое число ");
int numTwo = ReadInt("Введите второе число ");
ShowEvenNumbers(numOne, numTwo);