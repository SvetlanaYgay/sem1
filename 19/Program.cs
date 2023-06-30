// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("ВВедите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsPalindrome(int number)
{
    if (number / 10000 == number % 10 &&
          number / 1000 % 10 == number % 100 / 10)
          return true;
          return false;
}

Console.WriteLine(IsPalindrome(num));
