// Напишите программу которая принемает 
// на вход два числа и проверяет
// может ли существовать треугольник со сторонами такой длинны.

// Сумма двух других сторон должна быть больше третей. так для всех

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void CheckArray(int[] arr)
{
    int max = arr[0];
    int indMax = 0;
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            indMax = i;
            sum = sum + arr[i];
        }
    }
    sum = sum -arr[indMax];
    if (arr[indMax] < sum)
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
     else
    {
        Console.WriteLine("Такой треугольник не может существовать");
    }
    
}

int[] array = new int[3];
FillArray(array);
CheckArray(array);
