// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Вывод всех чётных чисел от 1 до введённого");
Console.WriteLine("Введите число");
int num=int.Parse(Console.ReadLine());
if (num==0||num==1||num==-1)
{
    Console.WriteLine($"Это число {num} . Нет данных для вывода ! Введите другое число");
    return;
}
else if (num>0)
{
    Console.Write($"Чётные числа числа {num}: ");
    int count=1;
    while (num+1>count)
    {
        if (count%2==0)
        {
            Console.Write($"{count} ");
            count++;
        }
        else
        {
            count++;
        }
    }
    return;
}
else if (num<0)
{
    Console.Write($"Чётные числа числа {num}: ");
    int count=1;
    while (num-1<count)
    {
        if (count%2==0&&count!=0)
        {
        Console.Write($"{count} ");
        count--;
        }
        else 
        {
            count--;
        }
    }
    return;
}
