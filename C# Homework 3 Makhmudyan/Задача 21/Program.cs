/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();
Console.WriteLine("Введите значение X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение X2: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Z1: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Z2: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"d = {d:f6}");

