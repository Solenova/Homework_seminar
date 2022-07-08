// Напишите программу, которая задаёт массив из 8 элементов, 
//заполненный псевдослучайными числами и выводит их на экран.
Console.Clear();
var rnd = new Random();
Console.Write("Введите количество элементов в целочисленном массиве ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижний числовой предел элементов массива ");
int minim = int.Parse(Console.ReadLine());
Console.Write("Введите верхний числовой предел элементов массива ");
int maxim = int.Parse(Console.ReadLine());
int[] arr = new int[size];

void FillArray(int[] mas, int min, int max)
{
    int legth = mas.Length;
    for (int i = 0; i < legth; i++)
    {
        mas[i] = rnd.Next(min, max+1);
    }
}
void PrintArray(int[] massiv)
{
    int coint = massiv.Length;
    Console.Write("[");
    for (int j = 0; j < coint; j++)
    {
        Console.Write($"{massiv[j]} ,");
    }
    Console.WriteLine("\b]");
}
FillArray(arr,minim,maxim);
PrintArray(arr);