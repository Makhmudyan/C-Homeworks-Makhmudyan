/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse (Console.ReadLine());

while (numberDayOfWeek < 6 || numberDayOfWeek > 7) 
{
    Console.WriteLine("Введен неправильный номер");
    Console.Write("Введите номер дня недели: ");
    numberDayOfWeek = int.Parse (Console.ReadLine());
}

Console.WriteLine("Это выходной день");
