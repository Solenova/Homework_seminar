int rndNum1 = new Random().Next(10, 100);
int rndNum2 = new Random().Next(1, 10);
int ost1 = rndNum1 % rndNum2;
if (ost1 == 0) Console.WriteLine($"{rndNum1} кратно {rndNum2} ");
else Console.WriteLine($"{rndNum1} не кратно {rndNum2}, остаток {ost1} ");
