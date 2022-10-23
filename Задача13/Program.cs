//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

int ThirdDigit(int a){
    if (a >= 100 && a < 1000)
{
    int temp = a % 10;
    int temp2 = temp / 1;
    return temp2;
}
if (a >= 1000 && a < 10000)
{
    int temp = a % 100;
    int temp2 = temp / 10;
    return temp2;
}    
if (a >= 10000 && a < 100000)
{
    int temp = a % 1000;
    int temp2 = temp / 100;
    return temp2;
}
return 0;
}    


Console.WriteLine("Введите любое число до 100000: ");
int a = int.Parse(Console.ReadLine());
int result = ThirdDigit(a);
if (result == 0)
   Console.WriteLine("Третьей цифры нет");
else
   Console.WriteLine(result);











//Console.WriteLine("Введите любое число: ");
//int a = int.Parse(Console.ReadLine());
//if (a < 100) Console.WriteLine("Третьей цифры нет");
//if (a >= 100 && a < 1000)
//{
//    int temp = a % 10;
//    int temp2 = temp / 1;
//    Console.WriteLine(temp2);
//}
//if (a >= 1000 && a < 10000)
//{
//    int temp = a % 100;
//    int temp2 = temp / 10;
//    Console.WriteLine(temp2);
//}
//if (a >= 10000 && a < 100000)
//{
//    int temp = a % 1000;
//    int temp2 = temp / 100;
//    Console.WriteLine(temp2);
//}
//int ThirdDigit(int a)
//{
//    int temp = a;
//    if (a < 100)
//        Console.WriteLine("Третьей цифры нет");
//    if (a >= 100 && a < 1000)
//    {
//        int temp = a % 100;
//        int temp2 = temp / 10;
//        return temp2;
//    }
//
//}
//Console.WriteLine("Введите любое трехзначное число: ");
//int a = int.Parse(Console.ReadLine());
//int result = ThirdDigit(a);
//Console.WriteLine(result);