//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int Weekend(int a){
    if (a == 6 || a == 7) return 1;
    if (a >= 1 && a <= 5) return 2;

    return -1;
}  


Console.WriteLine("Введите цифру для определения выходного: ");
int a = int.Parse(Console.ReadLine());

int result = Weekend(a);
if (result == 1)
   Console.WriteLine("Да");
if (result == 2)
   Console.WriteLine("Нет");
if (result < 0)
   Console.WriteLine("Цифра не относится ко дню недели");