// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Random rnd = new Random();
int[,] CreateArray(int rows, int columns) {
    var random = new Random();

    int[,] array = new int[rows, columns];
    for(var i = 0; i < rows; i++){
        for(var j = 0; j < columns; j ++){
            array[i, j] = random.Next(0, 11);
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
           Console.Write(" ");
        }
        Console.WriteLine();
    }
}


var array = CreateArray(rnd.Next(1, 5), rnd.Next(1, 5));
PrintArray(array);
Console.WriteLine();
var array2 = CreateArray(rnd.Next(1, 5), rnd.Next(1, 5));
PrintArray(array2);
Console.WriteLine();

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    else Console.WriteLine("Матрицы не переумножаються.");
    return matrix3;
}

var array3 = DivMatrix(array, array2);
PrintArray(array3);