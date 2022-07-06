//Напишите пограмму, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

Console.Write("Введите колчество элементов массива N");
int size=int.Parse(Console.ReadLine());
 var rnd = new Random();
 int[] arr = new int[size];

void FillArray(int [] size)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
Console.Write("[");    
for (int position = 0; position < count; position++)
    {
        Console.Write(col[position]);
    }
 Console.Write("]");
}
FillArray(arr);
PrintArray(arr);

  //по умолчанию заполняются нулями, и последняя позиция 7
                         //int[] array=new int[8]{21,5,1,3,54,8,63,54}