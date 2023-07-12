// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string message)
{
    System.Console.Write(message);                      
    int number = Convert.ToInt32(Console.ReadLine());  
    return number;                                     
}


int GiveSumNumbers(int numOne, int numTwo)
{
    if (numOne == numTwo) return numOne;
  return numOne + GiveSumNumbers(numOne + 1, numTwo);
}

int numOne = ReadInt("Введите первое число ");
int numTwo = ReadInt("Введите второе число ");
System.Console.WriteLine($"Сумма чисел равна {GiveSumNumbers(numOne, numTwo)}");