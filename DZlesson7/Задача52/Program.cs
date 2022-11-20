// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    double[,] array = new double[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-100, 101);
        }
    }
    return array;
}
void PrintArray(double[,] input)
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

double[,] FindArithmeticMean(double[,] input)
{
    int count = 0;
    for (int j = 0; j < input.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < input.GetLength(0); i++)
        {
            sum = sum + input[i, j];

        }
        count++;
        Console.WriteLine("Среднее арифметическое столбца " + count + " = " + Math.Round(sum / input.GetLength(0), 2));
    }
    return input;
}

var array = CreateArray(5, 6);
PrintArray(array);
Console.WriteLine();

FindArithmeticMean(array);
Console.WriteLine();