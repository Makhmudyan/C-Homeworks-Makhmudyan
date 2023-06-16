// Задача 54 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();
int minValue = 2;
int maxValue = 9;
int A = new Random().Next(minValue,maxValue);
int B = new Random().Next(minValue,maxValue);

int[,] array = GetRandomArray(A, B, 0, 10);
PrintArray(array);

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

int[,] GetChangeArray(int[,] arr)
{
    for (int y = 0; y < arr.GetLength(0) * arr.GetLength(1); y++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int k = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = k;
                }
            }
        }
    }
    return arr;
}

GetChangeArray(array);
PrintArray(array);