// Задайте двухмерный массив. Найдите  сумму диагонали


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

void FillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int[,] Transposition(int[,] array)
{
    int[,] resuult = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i; j < array.GetLength(1); j++)
            resuult[j,i]=array[i,j];
    return resuult;
}

int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputNumber("Введите максимальное значение случайных чисел: ");
int[,] array = new int[m, n];
FillArray(array, min, max);
Console.WriteLine(StringArray(array, ", "));
Console.WriteLine();
int[,] arrayT = Transposition(array);
Console.WriteLine(StringArray(arrayT, ", "));


// недоделано