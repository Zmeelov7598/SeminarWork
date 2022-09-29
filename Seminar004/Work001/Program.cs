int GetNumberThreeDigits()
{
    int num = 0;
    while(num < 99 || num > 999)
    {
        Console.WriteLine("Введите трехзначное число!");
        Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int a = GetNumberThreeDigits();

Console.WriteLine(a);