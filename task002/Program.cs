// Задача : Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clean();
Console.WriteLine("Программа нахождения наибольшего и наименьшего числа из двух введённых");
Console.Write("Введите первое число");
double num1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
double num2=int.Parse(Console.ReadLine());
if (num1>num2)
{
    Console.Writeline($"Первое число {num1} больше второго числа {num2}");
}
else if(num1<num2) 
{
    Console.Writeline($"Второе число {num2} больше первого числа {num1}");
}
else if(num1==num2) 
{
    Console.Writeline($"Первое число {num1} равно второму числу {num2}");
}
return;
