//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
   double [] a = Getint(b1,k1,b2,k2);
   Console.WriteLine($"координаты точки пересечения = [{a[0]}:{a[1]}]");
}


double [] Getint (double b1, double k1, double b2, double k2)
{
    double [] result = new double [2];
    result [0] = (b2-b1) / (k1-k2);
    result [1] = k1 * result[0] + b1;
    return result;
}
