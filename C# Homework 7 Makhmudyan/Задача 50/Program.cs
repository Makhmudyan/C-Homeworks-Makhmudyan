//Задача 50
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
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


WriteLine("Введите в какой строке находится элемент: ");
int rowPosition = int.Parse(ReadLine());
WriteLine("Введите в каком столбце находится элемент: ");
int columnPosition = int.Parse(ReadLine());

void GetValueinArray (int [,] arr)
{
    int i = 0;
    int j = 0;
    for( i = 0; i < arr.GetLength(0); i++)
    {
        for( j = 0; j < arr.GetLength(1); j++)
        {
            if(i==rowPosition && j==columnPosition)
            {
                 WriteLine($"{arr[i,j]}");
            }
        }     
    }
    if(rowPosition > i || columnPosition > j)
    {
        WriteLine("Такого элемента нет");
    }
}
GetValueinArray(array);
