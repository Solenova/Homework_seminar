// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//{rast:N2}
double[] CreatArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write($"{arr[i]:N2}; ");
        else Console.Write($"{arr[i]:N2} ]");
    }
}
double[] array = CreatArrayRndDouble(10, 1, 10);
PrintArray(array);

double MinMaxArrDouble(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    double res = max - min;
    return res;
}
double result = MinMaxArrDouble(array);
Console.Write($"\n Разница между Мах и Мин = {result:N2}");