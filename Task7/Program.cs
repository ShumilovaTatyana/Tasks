﻿// Дополнительные задачи.
// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 10;
{
    Console.WriteLine(num1);
}
