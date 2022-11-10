//Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
//452 -> 3
//82 -> 2
int[] array = new int[8];
void FillArray(int[] collection)
{
    int lenght = 8;
    int index = 0;
    while (index<lenght)
{
    Console.Write($"Введите число {index+1} массива. ");
    collection[index] = Convert.ToInt32 (Console.ReadLine());;
    index++;
}
}
void PrintArray(int[] array)
{
    int count = 8;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);