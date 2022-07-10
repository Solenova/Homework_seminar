// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
//Console.Clear();
int[] FillArrayRndInt(int size, int min, int max)
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
Console.Write("Введите количество элементов массива ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнюю границу диапазона элементов массива ");
int minim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу диапазона элементов массива ");
int maxim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска в массиве ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRndInt(length, minim, maxim);

// void NamberArr(int[] arr, int num)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num) count += 1;
//     }
//     if (count != 0) Console.WriteLine($"встречается {count} раз");
//     else Console.WriteLine($" НЕ встречается");
// }

string NamberArr2(int[] arr, int num)
{
    string result = "Нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            result = "Да";
            break;
        }
    }
    return result;
}

PrintArray(array);
Console.Write($"в этом массиве число {number} ");
string result2 = NamberArr2(array, number);
Console.WriteLine(result2);