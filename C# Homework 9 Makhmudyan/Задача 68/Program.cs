// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();
Write("Введите число M: ");
int M = int.Parse(ReadLine());
Write("Введите число N: ");
int N = int.Parse(ReadLine());

WriteLine(GetAkkerman(M, N));

int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return GetAkkerman(m - 1, 1);
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}