// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}
number = Math.Abs(number);
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }

    int third_digit = number % 10;
    Console.Write($"Третья цифра равна = {third_digit}");
}
