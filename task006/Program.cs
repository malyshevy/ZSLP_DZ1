//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Проверка числа на чётность");
Console.Write("Введите число ");
int num=int.Parse(Console.ReadLine());
int num2=Math.Abs(num);
if (num==0)
{
    Console.WriteLine($"Это число {num} ! Введите другое число");
    return;
}
else if ((num2%2)==1)
{
    Console.WriteLine($"Число {num} не является чётным");
    return;
}
else
{
    Console.WriteLine($"Число {num} является чётным");
}
return;
