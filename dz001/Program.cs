﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Привет! Введи первое число: ");
long a = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
long b = Convert.ToInt64(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max первое число ");
}
if (a < b)
{
    Console.WriteLine("max второе число ");
}
