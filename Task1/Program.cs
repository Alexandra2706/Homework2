// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

if (number < 100 || number > 999)
{
    Console.WriteLine("Число должно быть трехзначным");
    Environment.Exit(0);
}

int second_digit = (number / 10) % 10;

Console.Write($"Вторая цифра числа {number} равна = {second_digit}");
