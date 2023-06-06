//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
Console.WriteLine("Введите вещественные числа через пробел, используя знак '.', чтобы разделить целое число: ");
string elements = Console.ReadLine();
double [] baseArray = GetArrayFromString(elements);

double [] GetArrayFromString(string stringArray)
{
    string [] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double [] res = new double [nums.Length];

    for(int i = 0; i < nums.Length; i++)
    {
        res [i] = double.Parse(nums[i]);
    }
    return res;
}

double max = baseArray [0];
double min = baseArray [0];

for (int i = 0; i < baseArray.Length; i++)
{
    if (baseArray[i] > max)
    {
        max = baseArray[i];
    }
    if (baseArray[i] < min)
    {
        min = baseArray[i];
    }
}

Console.WriteLine($"[ {String.Join( ", ", elements)} ] -> {max} - {min} = {max-min}");