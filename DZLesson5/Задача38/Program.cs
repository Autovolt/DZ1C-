 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



 double[] NewRandomArray()

{
    double[] arr = new double[10];
    for (int i=0; i < 10 ; i++) 
    {
        arr[i]= new Random().Next();
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

double [] arr = NewRandomArray();

void DifMaxMin(double[] arr)
{
    
    double max = arr[0];
    double min = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
        if (arr[i]>max) max = arr[i];

        if (arr[i]<min) min = arr[i];

   }

   double dif = max - min;
   //dif = Math.Round(dif, 2);
   
   Console.WriteLine($"Минимальное число - {min}");
   Console.WriteLine($"Максимальное число - {max}");
   Console.WriteLine($"Разница между максимальным и минимальным числами - {dif}");
}

DifMaxMin(arr);