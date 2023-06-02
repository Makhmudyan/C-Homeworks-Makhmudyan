/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int [] GetArr (int n)
{
    int [] arr = new int [n];
    for (int i = 0; i < n; i++)
    {
        arr [i] = new Random().Next(100);
    }
    return arr;
}

int [] arr = GetArr (8);
Console.WriteLine($"{String.Join(",", arr)} -> [{String.Join(",", arr)}]");