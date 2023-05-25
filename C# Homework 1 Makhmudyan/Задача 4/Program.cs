// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
long N1 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long N2 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
long N3 = long.Parse(Console.ReadLine());
var numbers = new List<long> { N1, N2, N3};
long size = 3;
int index = 0;
long max = numbers[0];
while(index < size)
{
   if(numbers[index] > max)
   max = numbers[index];
   else
   index++;
}
//int max1 = Convert.ToInt64(max); как сделать так, чтобы принимал огромные числа??
Console.WriteLine($"Максимальное число: {max}.");










