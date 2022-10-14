// Задача 63: Задайте значение вещественное N. Напишите программу
// которая выведет все натуральные числа в промежутке от 1 до N.
// N=5->"1, 2, 3, 4, 5"

double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}

string WriteNumbersRecursion(int startNumber, double lastNumber)
{
    if (startNumber <=lastNumber)
        return startNumber + ", " + WriteNumbersRecursion(startNumber + 1, lastNumber);
    else
        return string.Empty;
}

Console.Write(WriteNumbersRecursion(1, GetNumberFromConsole()));
Console.WriteLine();