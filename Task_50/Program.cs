// Задача 50. Напишите  программу, которая на вход принимает индексы элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
double[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    double[,] arr = new double[m, n];
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
void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");
            else Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}
void SearchElement (double[,] arr, int posLine, int posColumn)
{
if (posLine<=arr.GetLength(0)&& posColumn<=arr.GetLength(1)) 
    Console.WriteLine($"{posLine}, {posColumn} -> {arr[posLine,posColumn]}");
else  Console.WriteLine($"{posLine}, {posColumn} -> такого числа в массиве нет");
}
double[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(arrayResult);
Console.Write("Введите 1 номер позиции элемента,который вы хотите увидеть ");
int posNam1= int.Parse(Console.ReadLine());
Console.Write("Введите 2 номер позиции элемента ");
int posNam2=int.Parse(Console.ReadLine());
SearchElement(arrayResult, posNam1,posNam2);