// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
/* Пример:

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Clear();
Console.WriteLine("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine());

if (Math.Pow(N1, 2) == N2 || Math.Pow(N2, 2) == N1) 
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
    
}