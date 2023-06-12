//Задача 47
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк: ");
int M = int.Parse(ReadLine());
WriteLine("Введите количество столбцов: ");
int N = int.Parse(ReadLine());
double minValue = -10;
double maxValue = 10;
double [,] matrix = new double [M,N];
void GetArray(double [,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int y = 0; y < matr.GetLength(1); y++)
        {
            double a = new Random().NextDouble()*(maxValue-minValue)+minValue;
            Console.Write($"{matr[i,y] = a:F1} ");
        }
        Console.WriteLine();
    }
    
}
GetArray(matrix);