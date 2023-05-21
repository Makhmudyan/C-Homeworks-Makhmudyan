// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int N3 = int.Parse(Console.ReadLine());
var numbers = new List<int> { N1, N2, N3};
int size = 3;
int index = 0;
int max = numbers[0];
while(index < size)
{
   if(numbers[index] > max)
   max = numbers[index];
   else
   index++;
}
//int max1 = Convert.ToInt64(max); как сделать так, чтобы принимал огромные числа??
Console.WriteLine($"Максимальное число: {max}.");










