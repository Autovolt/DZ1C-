// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

class Spiral
{
    int[,] matrix;
    int m_size;
    int currentCount;

    static void Main(string[] args)
    {
        Spiral s = new Spiral(4);
        s.DrawSpiral();
        
    }

    public Spiral(int size)
    {
        this.m_size = size;                 
        matrix = new int[size, size];
        currentCount = 1;
    }

    public void DrawSpiral()
    {
        int x = 0, y = 0, size = m_size;

        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                matrix[x, i] = currentCount++;
            }

            for (int j = x + 1; j <= x + size - 1; j++)
            {
                matrix[j, y + size - 1] = currentCount++;
            }

            for (int i = y + size - 2; i >= y; i--)
            {
                matrix[x + size - 1, i] = currentCount++;
            }

            for (int i = x + size - 2; i >= x + 1; i--)
            {
                matrix[i, y] = currentCount++;
            }

            x = x + 1;
            y = y + 1;
            size = size - 2;
        }
        PrintMatrix();
    }

    private void PrintMatrix()
    {
        for (int i = 0; i < m_size; i++)
        {
            for (int j = 0; j < m_size; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}