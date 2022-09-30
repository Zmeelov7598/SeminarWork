// вход число N и Выдает произвдение чисел от 1 до N;
// 4 => 24
int GetNumber()
{
    Console.WriteLine("Введите число N: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetProizv(int number)
{
    int proizv = 1;
    for (int i = 1; i <= number; i++)
    {
        proizv = proizv * i;
    }
    return proizv;
}
int num = GetNumber();
Console.WriteLine("Произведение цифр равно " + GetProizv(num));