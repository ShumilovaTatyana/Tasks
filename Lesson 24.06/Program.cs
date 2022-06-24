// Задача 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int rndNum = new Random ().Next(10, 100); //последнее значение -100- не включается в диапазон//
// Console.WriteLine ($"Случайное число из отрезка 10 - 99 => {rndNum}");
// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10;
// Console.Write($"наибольшая цифра числа {rndNum} => ");

// if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else ConsoleWriteLine (secondDigit);
// или
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); // ? тогда, : иначе//

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(result);

// void function(string str)
// {
//     Console.WtiteLine(str);
// }

int MaxDigit(int num)
{
   int firstDigit = num / 10;
   int secondDigit = num % 10;
   if (firstDigit == secondDigit) return 0;
   return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit (rndNum); //maxDigit - переменная, MaxDigit - метод..
string result  = maxDigit > 0 ? maxDigit.ToString() : "цифры одинаковые"; // ToString для указания цифры и текста в одной строке, число приводим к строке//
Console.Write($"наибольшая цифра числа {rndNum} => {result}");

// string s = "Hello";
// function(s);


// int rndNum3 = new Random ();
// while (true)
// {
//     int rnd = rndNum3.Next();
// }

