// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int i = a % 2;

if (i == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
