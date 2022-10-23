//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int[] GetCubeList(int a){

int[] CubeArray = new int[a];
int i = 0;
while (i < a)
{
    CubeArray[i] = (i + 1) * (i + 1) * (i + 1);
    Console.WriteLine(CubeArray[i]);
    i++;
}
    return CubeArray;
}



//Console.WriteLine(CubeList[]);
Console.WriteLine("Введите чило: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Кубы чисел следующие: ");
int[] CubeList = GetCubeList(a);