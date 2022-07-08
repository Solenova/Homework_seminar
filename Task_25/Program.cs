// Напишите цикл, который принимает на вход два числа (АиВ) 
//и возводит число А в натуральную степень В.
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());

void DegreeNum(int num, int degree)
{
    int step = 1;
    int i = 0;
    if (degree > 0)
    {
        while (i < degree)
        {
            try
            {
                checked
                {
                    step = step * num;
                    i++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Переполнение типа!");
                break;
            }
        }
        Console.WriteLine($"Число  {num} в степени {degree}= {step}");

    }
    else Console.Write("Стпень числа должна быть натуральным числом");
}
DegreeNum(a, b);
