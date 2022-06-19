// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// num1 += 2 значит увеличить значение переменной num1 на 2


Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
while (num1 < num)
{
    Console.WriteLine(num1 + 1);
    num1 += 2;
}