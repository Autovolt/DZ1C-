// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое необходимо найти");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}
void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}



int[,] FindNumber(int[,] input)
{
    int indexi = -1;
    int indexj = -1;

    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            if (input[i, j] == x)
            {
                indexi = i;
                indexj = j;
                Console.Write(
                    $"Данное число {x} есть в массиве на позиции: ({indexi}, {indexj})"
                );
            }

        }
    }
    if (indexi == -1 && indexj == -1) Console.Write($"Данного числа {x} нет в массиве.");
    return input;
}



var array = CreateArray(rows, columns);
PrintArray(array);
Console.WriteLine();

FindNumber(array);