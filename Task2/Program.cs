// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите число a: ");
// Console.Write("Введите число b: ");
// if (a > b);
// {    Console.WriteLine("{0} наибольшее число", a);
//     Console.WriteLine("{0} наименьшее число", b);
// } 
// else
// {
//     Console.WriteLine("{0} наибольшее число ", b);
//     Console.WriteLine("{0} наименьшее число", a);
// }
// {
//    Console.ReadLine();
// }

int a = -9;
int b = -3;
if (a > b)
{
    Console.WriteLine("{0} наибольшее число", a);
    Console.WriteLine("{0} наименьшее число", b);
}
else
{
    Console.WriteLine("{0} наибольшее число ", b);
    Console.WriteLine("{0} наименьшее число", a);
}
{
    Console.ReadLine();
}