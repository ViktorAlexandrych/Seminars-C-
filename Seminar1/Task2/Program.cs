// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введи первое число: ");

int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введи второе число: ");

int numberB = int.Parse(Console.ReadLine()!);

int sqr = numberB * numberB;
if (numberA == sqr) Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
else Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");