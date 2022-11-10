//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
int b = (int)Math.Log10(a) + 1;
void SumNumbers(int b)
{
    int sum = 0;
    for (int i = 1; i <= b; i++)
    {
        sum = sum + a%10;
        a = a/10;
       
    }
    Console.WriteLine($"Сумма всех цифр в числе A равна {sum}");
}
SumNumbers(b);