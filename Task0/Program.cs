﻿// See https://aka.ms/new-console-template for more information

// byte bt = 125; // 2^8
// int i = 5; // 2^32
// double d = 5.5; // 2^64
// string s = "Hello!";
// bool b = false;

// int a = 4;
// int x = 2022;
// double i2 = a/x;
// byte bt1 = (byte)x;
// int x1 = bt;
// Console.WriteLine (x1);

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 5;
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}");

