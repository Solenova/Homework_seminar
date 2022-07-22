// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[] CreatArray(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    array[0] = rnd.Next(10, 100);

    for (int i = 1; i < array.Length;)
    {
        int num = rnd.Next(10, 100);   
        int j;
        for (j = 0; j < i; j++)
        {
            if (num == array[j])
                break;
        }
        if (j == i)
        {
            array[i] = num;
            i++;
        }
    }
    return array;
}

int[,,] CreateMatrix3DManual(int row, int col, int line)
{
    int[,,] arr = new int[row, col, line];
    int size = row * col * line;
    int count = 0;
    int[] tempArray = CreatArray(size);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {

                arr[i, j, k] = tempArray[count];
                count++;
            }

        }
    }
    return arr;
}

void PrintMatrix(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)

    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {

            for (int j = 0; j < arr.GetLength(0); j++)
            {
                //if (k < arr.GetLength(2) - 1) Console.Write($"{arr[i, j,k],2}  ");
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

int[,,] array3D = CreateMatrix3DManual(2, 2, 2);
PrintMatrix(array3D);