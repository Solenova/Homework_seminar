// Задача 55. Задайте двумерный массив. Напишите программу, 
//которая  заменяет строки на столбцы, или выводит сообщение, что это невозможно.
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

int[,] ReplaceLineColumn(int[,] arr)
{
    
    int temp = 0;
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
          for (int j = 0; j < arr.GetLength(1); j++)
         {
                temp = arr[i, j];
                arr[i, j] = arr[j, i];
               arr[j, i] = temp;
         }
         }
         return arr;
    }
    else Console.WriteLine("Невозможно заменить, количество строк и столбцов не совпадает");
    
    
}
int[,] arrayResult = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayResult);
Console.WriteLine();
arrayResult = ReplaceLineColumn(arrayResult);
PrintMatrix(arrayResult);