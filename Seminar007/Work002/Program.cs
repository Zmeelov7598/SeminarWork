// Задайте двухмерный массив m на n
// Каждый эдемент в массиве находится по формуле Amn=m+n. Выведите полученный массив на экран

int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string StringArray(int[,] array, string split)
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    string textarray = String.Empty;
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            textarray += array[i, j];
            if (j < length1 - 1)
                textarray += split;
        }
        textarray += "\n";
    }
    return textarray;
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
        }
    }
}

int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: ");
int[,] array = new int[m,n];
FillArray(array);
Console.WriteLine(StringArray(array, ", "));