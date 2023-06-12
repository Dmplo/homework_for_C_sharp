// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Задача 1");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1 > num2 ? num1 : num2;
System.Console.WriteLine($"max = {max}");

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Задача 2");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maximum = number1;

if (number2 > maximum) {
 maximum = number2;
}
if (number3 > maximum) {
 maximum = number3;
}

System.Console.WriteLine($"Большее число из введенных это {maximum}");

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Задача 3");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string isEven = num % 2 == 0 ? "четное" : "не четное";
System.Console.WriteLine($"Введеное число {isEven}");

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Задача 4");

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= userNum) {
    if (i % 2 == 0)
    {
            System.Console.WriteLine(i);
    }
    i += 2;
}
