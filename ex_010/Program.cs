// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input any integer three-digit number: ");
int number = int.Parse(Console.ReadLine());
int digit2 = (number / 10) % 10;
Console.WriteLine($"{digit2}");