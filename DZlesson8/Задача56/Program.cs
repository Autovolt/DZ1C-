//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray(int rows, int columns) {
    var random = new Random();

    int[,] array = new int[rows, columns];
    for(var i = 0; i < rows; i++){
        for(var j = 0; j < columns; j ++){
            array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}
void PrintArray(int[,] input) {
    for(var i = 0; i < input.GetLength(0); i++)
    {
        for(var j = 0; j < input.GetLength(1); j ++)
        {
           Console.Write(input[i, j]);
           if (j != input.GetLength(1) - 1)
           Console.Write(", ");
        }
        Console.WriteLine();
    }
}


var array = CreateArray(4, 4);
PrintArray(array);
Console.WriteLine();

void SortSumRow(int[,] mas)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum += mas[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        line += mas[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - {index+1} ");
}

SortSumRow(array);
