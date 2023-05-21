// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int A = 1;
while(A <= N)
{
    if(A % 2 == 0)
    Console.Write($"{A} ");
    A++;
}

// Как завершить строку точкой?