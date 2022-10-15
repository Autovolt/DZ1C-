
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine())!;

int b = a % 2;

if(b == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}