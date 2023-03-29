﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
int secondNumber = (num /10) % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
}
else
Console.WriteLine($"Введенное число {num} не трехзначное");
