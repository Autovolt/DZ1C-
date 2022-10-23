//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

int Polidrom(int a)
{
    int temp = a;
    int reverse = 0;
    while (temp != 0)
    {
        reverse = (reverse * 10) + (temp % 10);
        temp = temp / 10;
    }
    return reverse;
}

Console.WriteLine("Введите пятизначное чило: ");
int a = int.Parse(Console.ReadLine());
int result = Polidrom(a);
if (result == a)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");