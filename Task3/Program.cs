// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

if (number == 6 || number == 7)
{
    Console.WriteLine("Да, это выходной день");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("Нет, это рабочий день");
}
else
{
    Console.WriteLine("Дня недели с таким номером не существует");
}
