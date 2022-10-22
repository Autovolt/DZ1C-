//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1
int SecondDigit(int a){
    int temp = a % 100;
    int temp2 = temp / 10;
    return temp2;
}

Console.WriteLine("Введите любое трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int result = SecondDigit(a);
Console.WriteLine(result);


//int temp = a % 100;
//int temp2 = temp / 10;
//Console.WriteLine(temp2);


