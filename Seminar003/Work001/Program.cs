int GetNumber()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());
}
bool CheckMod(int a, int mod)
{
    return (a % mod == 0);
}
int a = GetNumber();
if (CheckMod(a,7) && CheckMod(a,23))
    Console.WriteLine("Верно!");