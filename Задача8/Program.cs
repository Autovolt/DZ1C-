Console.WriteLine("Введите число: ");
int input = int.Parse(Console.ReadLine())!;

if(input >= 2)
{
int temp = 1;
 while(temp <= input)
 {
    if(temp % 2 == 0)
    {
        Console.Write(temp + " ");
    }
    temp++;
 }
}
else
{
    Console.WriteLine("Число должно быть положительным от 2 и более ");
    Console.WriteLine("Введите число: ");
    int input2 = int.Parse(Console.ReadLine())!;
    if (input2 >= 2)
    {
        int temp2 = 1;
        while (temp2 <= input2)
        {
            if (temp2 % 2 == 0)
            {
                Console.Write(temp2 + " ");
            }
            temp2++;

        }

    }
}