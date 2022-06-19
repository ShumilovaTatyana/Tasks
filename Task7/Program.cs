// Дополнительные задачи.
// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 10;
{
    Console.WriteLine(num1)
}


//  Console.WriteLine("4islo: ");
//     string a = Console.ReadLine();
//     Console.WriteLine("Posledniy simvol: " + a[2]);
//     Console.WriteLine("Sredniy simvol: " + a[1]);
//     Console.ReadKey();
// }
// int number, reminder;
//         //считывание целого числа
//         number = Int32.Parse(Interaction.InputBox("Введите целое число","Проверка"));
//         // вычисляется остаток деления на 2
//         reminder = number % 2;
//         string txt = "Вы ввели ";
//         txt += (reminder == 0 ? "чётное" : "нечётное") + " число!";
//         MessageBox.Show(txt);

//         double x = 10;
//         double y = 3;
//         double z;
//         z = x / y - y;
//         Console.WriteLine(z);
