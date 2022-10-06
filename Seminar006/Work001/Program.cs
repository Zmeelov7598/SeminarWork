// Напишите программу которая перевернет одномерный массив(первый станет последним)



void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] SwapArray(int[] arr)
{
    int[] tempArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArr[arr.Length - 1 - i] = arr[i];
    }
    return tempArr;
}

void SwapArrayTwo(int[] arr)
{
    int swap;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        swap = arr[arr.Length - i - 1];
        arr[arr.Length-i-1]=arr[i];
        arr[i]=swap;
    }
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine("Метод №1");
PrintArray(SwapArray(array));
Console.WriteLine("Метод №2");
SwapArrayTwo(array);
PrintArray(array);