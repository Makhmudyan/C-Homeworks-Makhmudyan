//Напишите программу, которая вводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

Console.Clear();
int num = new Random().Next(100,1000);

Console.WriteLine(num);
int result = (num / 100) * 10 + num % 10;

Console.WriteLine($"{result}");

