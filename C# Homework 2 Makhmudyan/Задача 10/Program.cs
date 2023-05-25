/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());


while (Math.Abs(number) < 100 || Math.Abs(number) > 999) 
{
    Console.WriteLine("Введено не трехзначное число: ");
    Console.Write("Введите трехзначное число: ");
    number = int.Parse (Console.ReadLine());
}
    int result = Math.Abs((number) / 10) % 10;
    Console.WriteLine($"{result}");
