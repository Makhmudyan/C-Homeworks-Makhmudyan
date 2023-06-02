/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
Console.WriteLine("Введите первое число: ");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double B = double.Parse(Console.ReadLine());
Console.WriteLine($"{A},{B} -> {Get(A)}");

double Get(double n)
{
    double F = Math.Pow (A,B);
    return F;
}