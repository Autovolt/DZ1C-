//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] NewRandomArray()

{
    int[] arr = new int[4];
    for (int i=0; i < 4 ; i++) 
    {
        arr[i]= new Random().Next(-100,100);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}
int [] arr = NewRandomArray();


void FindCount(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)  count =  count + arr[i];
               
    }
    Console.WriteLine("Сумма элементов на нечетных позициях = " + count);
     
}
FindCount(arr); 