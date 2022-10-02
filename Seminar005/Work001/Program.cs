void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sum += arr[i];
    }
    return sum;
}

int[] massiv = new int[12];
FillArray(massiv);
PrintArray(massiv);