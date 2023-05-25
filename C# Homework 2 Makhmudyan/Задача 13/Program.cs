/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("Введите число: ");
long number = long.Parse (Console.ReadLine());
int index = 0;

if (Math.Abs((number) / 100) % 10 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    while (Math.Abs((number) / 1000) != 0)
    {
        number = number / 10;
        index++;
    }
}
Console.WriteLine($"{Math.Abs(number) % 10}");