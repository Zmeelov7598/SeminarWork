// реализовать метод деление олного двухмерного массива на другой


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

void PrintArray(double[,] arr)
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

int GetDeterminate2x2(int[,] minor)
{
return minor[0,0] * minor[1,1] - minor[0,1] * minor[1,0];
}

int GetDeterminate3x3(int[,] arr)
{
return 3;
}

int[,] DeleteLines(int[,] arr, int posRow, int posColum)
{
    int k = 0, l = 0;
    int[,] resultArr = new int[2,2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i!=posRow)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != posColum)
                {
                    resultArr[k,l] = arr[i,j];
                    l++;
                }
            }
            l = 0;
            k++;
        }
    }
    return resultArr;
}

int[,] GetMassivOfMinors(int[,] arr)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[i,j] = Convert.ToInt32(Math.Pow(-1,i+j)) * GetDeterminate2x2(DeleteLines(arr,i,j));
        }
    }
    return resultArr;
}

int[,] GetTranspositionMassiv(int[,] arr)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[i,j] = arr[i,j];
        }
    }
    return resultArr;
}

double[,] GetDivisionMassivAndChislo(int[,] arr, int number)
{
    double[,] resultArr = new double[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[i,j] = arr[i,j]/number;
        }
    }
    return resultArr;
}

double[,] GetReversArray(double[,] arr)
{
    double[,] resultArr = new double[arr.GetLength(0), arr.GetLength(1)];

    resultArr = GetDivisionMassivAndChislo(GetTranspositionMassiv(GetMassivOfMinors(arr)),GetDeterminate3x3(arr));
    return resultArr;
}

double[,] GetDivision(double[,] arrNom, double[,] arrDenom)
{
    return GetMultiArrays(arrNom,GetReversArray(arrDenom));
}

double [,] GetMultiArrays(double[,] array1, double[,] array2)
{
    double[,] mult = new double[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0);i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            mult[i,j] = 0;
            for (int k = 0; k< array1.GetLength(1); k++)
            {
                mult[i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return mult;
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите рамерность массива n");
int[,] array1 = InitializateArray(m, n);
int[,] array2 = InitializateArray(m, n);
int minValue = GetNumberFromConsole("Введите минимальное значение, допустимое для массива");
int maxValue = GetNumberFromConsole("Введите максимальное значение, допустимое для массива");
FillArray(array1, minValue, maxValue);
FillArray(array2, minValue, maxValue);

PrintArray(array1);

PrintArray(DeleteLines(array1, 1, 1));

if ((m==3) && (n==3))
    PrintArray(GetDivision(array1,array2));


// все пошло крахом изза деления и дабл