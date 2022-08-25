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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100)
{
    Console.Write($"Третья цифра в числе {number} отсутствует. Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

string result = number.ToString();

Console.WriteLine($"Третья цифра числа {number} - {result[2]}");
