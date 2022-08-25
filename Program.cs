// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number < 100 || number > 999)
// {
//     Console.Write("Вы ввели неправильное число! Введите трехзначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// string result = number.ToString();

// Console.WriteLine($"Вторая цифра числа {number} - {result[1]}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number < 100)
// {
//     Console.Write($"Третья цифра в числе {number} отсутствует. Введите число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// string result = number.ToString();

// Console.WriteLine($"Третья цифра числа {number} - {result[2]}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number < 1 | number > 7)
// {
//     Console.Write($"Дня недели с номером {number} не существует. Введите номер дня недели: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// if (number >= 1 & number <= 5)
// {
//     Console.Write($"День недели с номером {number} является будним днем");
// }
// else if (number == 6 | number == 7)
//     {
//        Console.Write($"День недели с номером {number} является выходным днем"); 
//     }

// Дополнительная задача. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 7 == 0) & (number % 23 == 0))
{
    Console.Write($"Число {number} является кратным числам 7 и 23 одновременно");
}
else
{
    Console.Write($"Число {number} не является кратным числам 7 и 23 одновременно");
}