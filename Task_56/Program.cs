// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SummElementRowMatrix(int[,] arr)
{
    int[] newArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];

        }
        newArray[i] = summ;
    }

    return newArray;
}

int MinElement(int[] summElem)
{
    int count=0;
    int min = summElem[0];
    for (int i = 0; i < summElem.Length; i++)
    {
        if (summElem[i] < min) 
        {
            min = summElem[i]; count = i;
        }
    }
    return count;
}


int[,] arrayResult = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(arrayResult);
int[] arraySumm=SummElementRowMatrix(arrayResult);
int numMinSummRow = MinElement(arraySumm);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numMinSummRow} строка");

