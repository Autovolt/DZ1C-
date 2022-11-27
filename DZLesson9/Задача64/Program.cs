// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не натуральное число");
}
else Console.WriteLine(Recurtion(n, m));

int Recurtion(int n, int m)
{

    if (n == m)
        return n;
    else
        Console.Write($"{Recurtion(n, m + 1)}, ");
    return m;
}
