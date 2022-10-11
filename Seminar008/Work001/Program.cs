// Задайте двумерный массив. Напишите программу
// Которая поменяет местами первую и последнюю строку массива.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetRandomValue(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m, n];
}

void ChangeArray(int[,] arr)
{
    int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
    arr2 = arr;
    int temp;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) -1, j] = temp;
    }
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите рамерность массива n");
int[,] array = InitializateArray(m, n);
int minValue = GetNumberFromConsole("Введите минимальное значение, допустимое для массива");
int maxValue = GetNumberFromConsole("Введите максимальное значение, допустимое для массива");
FillArray(array, minValue, maxValue);

PrintArray(array);

ChangeArray(array);
Console.WriteLine();
PrintArray(array);

/// ХЗ муть какаято