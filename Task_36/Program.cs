// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int QuantityEvenArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count += arr[i];
    }
    return (count);
}

Console.Write("Введите количество элементов массива ");
int length=Convert.ToInt32(Console.ReadLine());

int[] array=CreatArrayRndInt(length,0,10);
PrintArray(array);
int result=QuantityEvenArr(array);
Console.WriteLine($"\n Сумма элементов, стоящих на нечетных позициях равна {result}");