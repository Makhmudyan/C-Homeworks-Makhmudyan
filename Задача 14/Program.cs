// // Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else 
{
     Console.WriteLine($"Число {number} не кратно 7 и 23");
}
