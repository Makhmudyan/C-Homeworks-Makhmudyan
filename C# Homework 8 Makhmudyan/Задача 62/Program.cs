// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;
Clear();
int a = 4;
int b = 4;

//int [,] matrix = new int [a,b];
int[,] GetMatrixArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
        }
    }
    return result;
}
/*
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

PrintArray(GetMatrixArray(a,b));
*/

GetMatrixArray(a, b);
WriteLine();

int [,] re = GetMatrixArray(a,b);

void FillImage(int [,] arr)
{

    if (arr[arr.GetLength(0), arr.GetLength(1)] == 0)
    {
        
        FillImage(GetMatrixArray(arr.GetLength(0) - 1, arr.GetLength(1)));
        FillImage(GetMatrixArray(arr.GetLength(0), arr.GetLength(1) - 1));
        FillImage(GetMatrixArray(arr.GetLength(0) + 1, arr.GetLength(1)));
        FillImage(GetMatrixArray(arr.GetLength(0), arr.GetLength(1) + 1));
       
        
    }
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++ )
    {
        int count = 0;
        for( int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{count++} ");
            //if(image[i,j] == 0) Console.Write($"{count++} ");
        }
    Console.WriteLine();
    }
} 

FillImage(re);
PrintImage(re);
