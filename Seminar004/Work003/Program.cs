//Напишите программу которое на вход принимает число и выдает количество цифр в числе
//456 => 3
int InputNumber()
{
    Console.WriteLine("Введите сило!");
    return Convert.ToInt32(Console.ReadLine());
}

int GetDigCount(int Number)
{
    int DigCount = 0;
   // Number = Math.Abs(Number/10);
    while (Math.Abs(Number) > 0)
    {
        Number = Number / 10;
        DigCount++;
    }
    return DigCount;
}
Console.WriteLine("Количество цифр в числе " + GetDigCount(InputNumber()));
