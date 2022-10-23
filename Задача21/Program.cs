//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double distance(int[] dotA, int[] dotB)
{

    return Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2) + Math.Pow(dotB[2] - dotA[2], 2));
}

int[] dotA = new int[3];
int[] dotB = new int[3];

Console.WriteLine("Введите координату X точки A: ");
dotA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки A: ");
dotA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки A: ");
dotA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B: ");
dotB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B: ");
dotB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки B: ");
dotB[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distance(dotA, dotB), 2));