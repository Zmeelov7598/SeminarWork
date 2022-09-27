int Number()
{
    Console.WriteLine("Введите число! ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetPrintPow(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.Write(" " + Math.Pow(count, 2));
        count++;
    }
}
GetPrintPow(Number());
