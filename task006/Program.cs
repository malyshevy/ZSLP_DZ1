//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Проверка числа на чётность");
Console.Write("Введите число ");
int num=int.Parse(Console.ReadLine());
if (num==0)
{
    Console.WriteLine($"Это число {num} ! Введите другое число");
    return;
}
else if ((num%2)==0)
{
    Console.WriteLine($"Число {num} является чётным");
    return;
}
else
{
    Console.WriteLine($"Число {num} не является чётным");
}
return;
