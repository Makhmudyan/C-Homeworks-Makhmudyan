// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;
using static System.Console;
Clear();
int minValue = 4;
int maxValue = 6;
int a = new Random().Next(minValue,maxValue);
int b = new Random().Next(minValue,maxValue);
int c = new Random().Next(minValue,maxValue);

if(a*b*c > 90)
{
    WriteLine("Двузначных неповторяющихся чисел недостаточно. Нажмите 'control C' чтобы завершить программу");
}

int [,,] array = GetArray(a,b,c);
Console.WriteLine();
PrintArray(array);
int [,,] GetArray(int a, int b, int c)
{
    int [,,] result = new int [a,b,c];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(2); j++)
        {
            int k = 0;
            while(k < result.GetLength(1))
            {
                int el = new Random().Next(10,100);
                if(FindElement(result,el)) continue;
                result[i,k,j] = el;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k]==el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int [,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

