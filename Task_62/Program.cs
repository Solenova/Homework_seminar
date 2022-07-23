// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] CreateMatrixSpiral(int m, int n)
{
    int[,] arr = new int[m, n];
    int count = 1;
    int iBegin = 0, jEnd = 0, iEnd = 0, jBegin = 0;
    int i = 0;
    int j = 0;
    while (count <= n * m)
    {
        arr[i, j] = count;
        if (i == iBegin && j < m - jEnd - 1)
            j++;
        else if (j == m - jEnd - 1 && i < n - iEnd - 1)
            i++;
        else if (i == n - iEnd - 1 && j > jEnd)
            j--;
        else if (j == jBegin && i > iEnd-1)
            i--;
        if ((i == iBegin + 1) && (j == jBegin) && (jBegin != m - jEnd - 1))
        {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;
        }
        count++;
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
int[,] arraySpiral = CreateMatrixSpiral(4, 4);
PrintMatrix(arraySpiral);