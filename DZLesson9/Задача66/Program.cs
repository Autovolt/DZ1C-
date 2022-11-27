// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int Sum(int n)
{
    if (n==m) return 0;
    return  n + Sum(n - 1); 
}

Console.WriteLine(m + Sum(n));