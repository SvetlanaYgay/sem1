﻿// максимальное из трех

Console.Clear ();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=0;

if (a > max)
{
    max = a;
}
if (b > max);
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine("max = " + max);

