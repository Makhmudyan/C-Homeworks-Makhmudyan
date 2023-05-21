// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int max = number1;

if(max < number2)
{
    Console.WriteLine($"Большее число: {number2}");
    Console.WriteLine($"Меньшее число: {number1}");

}
else
{
    Console.WriteLine($"Большее число: {number1}");
    Console.WriteLine($"Меньшее число: {number2}");
}