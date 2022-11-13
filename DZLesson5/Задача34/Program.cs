//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] NewRandomArray()

{
    int[] arr = new int[4];
    for (int i=0; i < 4 ; i++) 
    {
        arr[i]= new Random().Next(99,1000);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

void FindCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine("Колличество чётных чисел в массиве равна: " + count);
}

int [] arr = NewRandomArray();
FindCount(arr);



