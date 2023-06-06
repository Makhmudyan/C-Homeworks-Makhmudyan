//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
//элементов,стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> ");

int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int [] GetSumOddPosition(int [] arr)
{
    int [] result = new int [2];
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (i%2 != 0)
        {
            result [0] += arr [i];
        }
        else
        {
            result [1] = 0;
        }
    }
    
    return result;
}


Console.Clear();
int [] A = GetRandomArray(5, 0, 10);
Console.WriteLine(String.Join( ", ", A));
Console.WriteLine($"[ {String.Join(", ", A)}] ->  {GetSumOddPosition(A)[0]} ");