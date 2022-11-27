// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите высоту трехмерного массива");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину трехмерного массива");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину трехмерного массива");
int z = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int [,,] mas = Fillimageay(x,y,z);
Printimageay(mas);

int[,,] Fillimageay(int x, int y, int z)
{
    int min = 1;
    int max = 100;
    int[,,] mas = new int[x,y,z];
    {
        for (int i=0;i<mas.GetLength(0);i++)
        {
            for (int j=0;j<mas.GetLength(1);j++)
            {
                for (int k = 0; k < mas.GetLength(2); k++) 
                { 
                    mas[i, j, k] = GetUniqueValue(mas, min, max, i, j, k);
                }
                          
            }
        }
    Console.WriteLine(); 
    }
    
    return mas;
}

int GetUniqueValue(int[,,] mas, int min, int max, int i, int j, int k)
{
    
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool Break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < mas.GetLength(0); i1++)
        {
            if (Break) { break; }
            for (int j1 = 0; j1 < mas.GetLength(1); j1++)
            {
                if (Break) { break; }
                for (int k1 = 0; k1 < mas.GetLength(2); k1++)
                {
                    if (mas[i1, j1, k1] == value) { Break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}

void Printimageay(int[,,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++) { Console.Write($"{mas[i, j, k],1}({i},{j},{k})"); }
            Console.WriteLine();
                       
        }
        Console.WriteLine();
    }
}