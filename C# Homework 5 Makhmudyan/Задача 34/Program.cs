//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

int [] GetEven(int [] arr)
{
    int [] result = new int [1];
    foreach(int el in arr)
    {
        result [0] += el % 2 == 0? 1 : 0;
    }
    return result;
}

Console.Clear();
int [] A = GetRandomArray(4, 100, 999);
Console.WriteLine(String.Join( ", ", A));
//int [] R = GetEven(A);

Console.WriteLine($"[ {String.Join(", ", A)}] ->  {GetEven(A)[0]} ");



