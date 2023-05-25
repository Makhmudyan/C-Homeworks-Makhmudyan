// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number2 % number1 == 0)
{
    Console.WriteLine($"Число {number2} кратно {number1}");
}
else
{
     Console.WriteLine($"Число {number2} не кратно {number1}, остаток {number1 % number2}");
}

