// // Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
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

int[] OppositNam (int[] arr)
{
for (int i=0; i<arr.Length; i++) arr[i]*=-1;
return (arr);
}
Console.Write("Введите количество элементов массива ");
int length=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнюю границу диапазона элементов массива ");
int minim=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу диапазона элементов массива ");
int maxim=Convert.ToInt32(Console.ReadLine());
int[] array=CreatArrayRndInt (length,minim,maxim);
PrintArray(array);
Console.WriteLine();
array=OppositNam(array);
PrintArray(array);
// void PrintSumPosNegElem(int[] sum)
// {
//     Console.WriteLine();
//     Console.WriteLine($"Сумма положительных чисел = {sum[0]}");
//     Console.WriteLine($"Сумма отрицательных чисел = {sum[1]}");
// }
// int[] array=CreatArrayRndInt(12,-9,9);
// PrintArray(array);
// int [] sumPosNegElem=GetSumPosNegElem(array);
// PrintSumPosNegElem(sumPosNegElem);