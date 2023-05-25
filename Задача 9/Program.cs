//Напишиту программу, которая вводит случаное число из отрезка [10,99]
//и показывает наибольшую цифру числа.

Console.Clear();
int num = new Random().Next(10,100);
int num1 = num / 10;
int num2 = num % 10;
int max = num1;

if (num1 > max)
{
     max = num1;
}
Console.WriteLine($"Max no of {num} is {max}");