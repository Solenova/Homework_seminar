var rnd1=new Random ();

int rndNum1 = rnd1.Next(10, 100);
int rndNum2 = rnd1.Next(1, 10);
Console.WriteLine(rndNum1);
Console.WriteLine(rndNum2);
string  result = rndNum1 % rndNum2 != 0 ? $"{rndNum1} не кратно {rndNum2}, остаток {rndNum1 % rndNum2}" : $"{rndNum1} кратно {rndNum2} ";
Console.WriteLine(result);
//2 способ
//int ost1 = rndNum1 % rndNum2;
//if (ost1 == 0) Console.WriteLine($"{rndNum1} кратно {rndNum2} ");
//else Console.WriteLine($"{rndNum1} не кратно {rndNum2}, остаток {ost1} ");


