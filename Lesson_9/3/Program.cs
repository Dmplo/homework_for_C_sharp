// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Ackerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

int numOne = ReadInt("Введите первое число ");
int numTwo = ReadInt("Введите второе число ");
System.Console.WriteLine($"A(m,n) = {Ackerman(numOne, numTwo)}");