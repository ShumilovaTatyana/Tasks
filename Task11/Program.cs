// 1. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе
// удаляет вторую цифру.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
// int firstDigit = num / 100;
// int secondDigit = num % 10;

// int result = firstDigit * 10 + secondDigit;
// Console.Write(result);

int RemoveSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}
int removeSecondDigit = RemoveSecondDigit (num);
Console.Write(removeSecondDigit);