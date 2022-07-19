// Задача 53. Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
Console.Clear();

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] ReplaceLine(int[,] arr)
{

    int temp = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }

    return arr;
}
int[,] arrayResult = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayResult);
Console.WriteLine();
arrayResult = ReplaceLine(arrayResult);
PrintMatrix(arrayResult);