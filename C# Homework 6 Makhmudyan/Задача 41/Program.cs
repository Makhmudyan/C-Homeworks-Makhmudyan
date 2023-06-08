//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string numbers = Console.ReadLine();
int [] a = GetArrayFromString(numbers);
Console.WriteLine($"{String.Join (", ", numbers)} -> {GetPos(a)[0]} ");

int [] GetArrayFromString(string stringArray)
{
    string [] nums = stringArray.Split(" ");
    int [] result = new int [nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result [i] = int.Parse (nums[i]);
    }
    return result;
}

int [] GetPos (int [] arr)
{//int count = 0;
    int [] result = new int [1]; //for(int i = 0; i < arr.Length; i++)
    //if(arr[i]>=0)
    {
    }
    foreach(int el in arr)
    {
        result [0] += el > 0? 1:0;
    }
    return result;
}