// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],2}  ");
            else Console.Write($"{arr[i, j],2}  ");
        }
        Console.WriteLine();
    }
}

int[,] СompositionMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] compositionAB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            compositionAB[i,j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                compositionAB[i,j] += matrixA[i,k] * matrixB[k,j];
            }
        }
    }
    return compositionAB;
}
int[,] arrayA = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(arrayA);
Console.WriteLine();
int[,] arrayB = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(arrayB);
Console.WriteLine();
if (arrayA.GetLength(1)==arrayB.GetLength(0)) 
{
    int[,] resultAB= СompositionMatrix(arrayA, arrayB);
PrintMatrix(resultAB);
}
else Console.WriteLine("Матрицы не согласованы, невозможно найти их произведение");