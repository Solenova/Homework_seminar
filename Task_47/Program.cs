// Задача 47 : Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    double[,] arr = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();
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
            //if (j == 0) Console.Write(" ");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3:N1} ");
            else Console.Write($"{arr[i, j], 3:N1}  ");
        }
        Console.WriteLine();
    }
}
Console.Write ("Введите количество строк в массиве ");
int quantityLine =int.Parse(Console.ReadLine());
Console.Write ("Введите количество столбцов в массиве ");
int quantityColumn =int.Parse(Console.ReadLine());
double[,] arrayResult = CreateMatrixRndInt(quantityLine, quantityColumn, 1, 20);
PrintMatrix(arrayResult);