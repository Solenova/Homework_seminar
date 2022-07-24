// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("m= ");
uint num = Convert.ToUInt32(Console.ReadLine());
Console.Write("n= ");
uint numEnd = Convert.ToUInt32(Console.ReadLine());
uint result=fAkkerman(num,numEnd);
Console.Write($"A({num},{numEnd}) = {result}");
static uint fAkkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return fAkkerman(n - 1, 1);
    else
      return fAkkerman(n - 1, fAkkerman(n, m - 1));
}
