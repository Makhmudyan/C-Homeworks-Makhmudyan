// Задача 66
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int M = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int N = int.Parse(ReadLine());
WriteLine(GetNumbersSum(M, N));

int GetNumbersSum (int m, int n)
{
    if(m == n)
        return n;
    return (m + GetNumbersSum(m + 1, n));
}
