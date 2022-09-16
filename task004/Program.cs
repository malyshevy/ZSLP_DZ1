// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Программа нахождения наибольшего из трёх чисел");
Console.Write("Введите 1е число ");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите 2е число ");
int num2=int.Parse(Console.ReadLine());
Console.Write("Введите 3е число ");
int num3=int.Parse(Console.ReadLine());
int max=num1;
if (num1==num2 && num2==num3)
{
    Console.WriteLine($"Числа равны , наибольшего числа нет");
    return;
}
else if (num2>max && num2>num3)
{
    max=num2;
    Console.WriteLine($"Второе число наибольшее {max}");
    return;
}
if (num3>max)
{
    max=num3;
    Console.WriteLine($"Третье число наибольшее {max}");
    return;
}
else
{
Console.WriteLine($"Первое число наибольшее {max}");
}
return;