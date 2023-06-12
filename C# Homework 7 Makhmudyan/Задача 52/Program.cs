//Задача 52
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();
int minValue = 4;
int maxValue = 9;
int A = new Random().Next(minValue,maxValue);
int B = new Random().Next(minValue,maxValue);

int [,] array = GetRandomArray(A, B, 0, 10);
PrintArray(array);
int [,] GetRandomArray(int a, int b, int minValue, int maxValue)
{
    int [,] result = new int [a,b];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

void PrintArray (int [,] arr)
{
    for(int i= 0; i < arr.GetLength(0); i++)
    {
        for(int j= 0; j< arr.GetLength(1); j++)
        {
            Write($" {arr[i,j]} ");
        }
        WriteLine();
    }
}
WriteLine();

void GetAve (int [,] arr)
{
    for(int j = 0; j < B; j++)
    {
        double sum = 0;
        for(int i = 0; i < A; i++)
        {
            sum += arr [i,j];
        }
        double average = sum/A;
        Write($"{(average):f2} ");
    }
}
GetAve(array);


/*
int [] GetI(int [,]arr)
{
    int [] result = new int [arr.GetLength(0)];
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            result [i] = arr [i,j];
        }

    }
    return result;
}

void PrintArray2 (int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Write($"{String.Join(" ",arr[i])}");
    }
}

int [] result = GetI(array);

void GetAverage (int [] arr)
{
    int average = 0;
    foreach(int el in arr)
    {
        average += el; 
    }
    double A = Convert.ToDouble(average);
    WriteLine($"{(A /= arr.Length):f2}");  
}

PrintArray2(result);
WriteLine();
GetAverage(result);
*/


