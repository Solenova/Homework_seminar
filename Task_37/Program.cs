// Найти произведение пар сивел в одномерном массиве. Парой считаем первый 
//и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

void CompositionArr(int[] arr)
{
    //int[] newArr = new int[arr.Length / 2];
    int n=0;
    if (arr.Length % 2 == 0)//0
    {
         n = arr.Length / 2;//5
    }
    else
    {
         n = arr.Length / 2 + 1;
    }
 int[] newArr = new int[n];//
    for (int i = 0; i <=n+1; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length-1-i];
        Console.Write($" {newArr[i]}");
    }
}
int[] array = CreatArrayRndInt(10, 0, 10);
PrintArray(array);
CompositionArr(array);