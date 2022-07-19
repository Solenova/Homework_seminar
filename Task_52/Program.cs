// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] FillMatrixArray(int sizeLine, int sizeColumn, int min, int max)
{
    int[,] arr = new int[sizeLine, sizeColumn];
    var rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)

        {
            arr[i, j] = rnd.Next(min, max + 1);
        }

    }
    return arr;
}

void PrintMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)

        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.Write(" ");
}

void PrintArithmetic(int[,] arr)
{
    Console.Write("Среднее арифметичecкое каждого столбца:");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < arr.GetLength(0); i++)

        {
            summ += arr[i, j];
        }

        if (j <= arr.GetLength(1) - 2)
        {
            Console.Write($" {summ / arr.GetLength(0):N1} ;");
        }
        else Console.Write($" {summ / arr.GetLength(0):N1} .");

    }
    Console.WriteLine("\b");
}
Console.Write ("Введите количество строк в массиве ");
int quantityLine =int.Parse(Console.ReadLine());
Console.Write ("Введите количество столбцов в массиве ");
int quantityColumn =int.Parse(Console.ReadLine());
int[,] arrResult = FillMatrixArray(quantityLine, quantityColumn, -10, 10);
PrintMatrixArray(arrResult);
PrintArithmetic(arrResult);

