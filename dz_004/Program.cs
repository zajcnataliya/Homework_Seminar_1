﻿// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// задача на цикл

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int counter = 2;
while (counter <= number)
{
    Console.WriteLine(counter);
    counter=counter + 2;
}