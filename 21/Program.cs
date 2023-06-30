// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter X for first point ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y for first point ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z for first point ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X for second point ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y for second point ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z for second point ");
int bZ = Convert.ToInt32(Console.ReadLine());

double a = Math.Pow((aX-bX),2);
double b = Math.Pow((aY-bY),2);
double c = Math.Pow((aZ-bZ),2);

double length = Math.Sqrt(a+b+c);
Console.WriteLine($"Расстояние между двух точек в трехмерном пространстве --> {Math.Round (length, 2)}");


