// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

while(number % 2 != 0)

{
    Console.WriteLine("Данное число является нечетным. Введите другое число: ");
    number = int.Parse(Console.ReadLine());
}

if(number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным.");
}

// Сделала таким образом, чтобы усложнить себе задачу
