// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли 
// этот день выходным.

Console.Write("Input day of the week number from 1 till 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
    Console.Write("YES");
else
    Console.Write("NO");