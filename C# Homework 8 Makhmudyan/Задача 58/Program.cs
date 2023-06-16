// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System;
using static System.Console;
Clear();
WriteLine("Введите количество строк первой матрицы: ");
int A = int.Parse(ReadLine());
WriteLine("Введите количество столбцов первой матрицы: ");
int B = int.Parse(ReadLine());
WriteLine("Введите количество строк второй матрицы: ");
int C = int.Parse(ReadLine());
WriteLine("Введите количество столбцов второй матрицы: ");
int D = int.Parse(ReadLine());

int[,] array = GetRandomArray(A, B, 0, 10);
PrintArray(array);
WriteLine();
int[,] array2 = GetRandomArray(C, D, 0, 10);
PrintArray(array2);
int[,] GetRandomArray(int a, int b, int minValue, int maxValue)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}



void PrintArray(int[,] arr)
{ 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($" {arr[i, j]} ");
        }
        WriteLine();
    }
}
WriteLine();

if(A != D)
{
    WriteLine("Нельзя найти произведение таких матриц");
}


int [,] GetFinalArray(int [,] arr, int [,] arr2)
{
    int [,] result = new int [arr.GetLength(0), arr2.GetLength(1)];
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(1);k++)
            {
                result [i,j] += arr[i,k] * arr2[k, j];
            } 
        }
    }
    return result;
}

PrintArray(GetFinalArray(array, array2));