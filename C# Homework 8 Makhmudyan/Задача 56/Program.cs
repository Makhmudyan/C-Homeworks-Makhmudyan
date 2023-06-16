// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;
Clear();
int minValue = 4;
int maxValue = 9;
int A = new Random().Next(minValue, maxValue);
int B = new Random().Next(minValue, maxValue);

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

int[] GetRowSum(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];
    int y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        result[i] = sum;
    }
    return result;
}

WriteLine($"{String.Join(" ", GetRowSum(array))}");

int GetMinInArray(int[] arr)
{
    int min = 0;
   
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min])
        {
            min = i;
        }
    }
    return min + 1;
}

WriteLine();
int[] a = GetRowSum(array);

WriteLine($"Номер строки с наименьшей суммой элементов: {String.Join(" ",GetMinInArray(a)) }");

GetMinInArray(a);