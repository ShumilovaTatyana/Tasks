// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{   
    Console.WriteLine("{0} наибольшее число", num1);
    Console.WriteLine("{0} наименьшее число", num2);
} 
else
{
    Console.WriteLine("{0} наибольшее число ", num2);
    Console.WriteLine("{0} наименьшее число", num1);
}
{
   Console.ReadLine();
}

// int a = -9;
// int b = -3;
// if (a > b)
// {
//     Console.WriteLine("{0} наибольшее число", a);
//     Console.WriteLine("{0} наименьшее число", b);
// }
// else
// {
//     Console.WriteLine("{0} наибольшее число ", b);
//     Console.WriteLine("{0} наименьшее число", a);
// }
// {
//     Console.ReadLine();
// }