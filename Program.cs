// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.Write("Вы ввели неправильное число! Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

string result = number.ToString();

Console.WriteLine($"Вторая цифра числа {number} - {result[2]}");

