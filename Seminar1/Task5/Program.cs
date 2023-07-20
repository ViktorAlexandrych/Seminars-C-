// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
System.Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
// int number = Prompt(«Введите трехзначное число»);
if (number >= 100 && number < 1000)
{
	int last = (number % 10);
	System.Console.WriteLine($"Вторая цифра числа {number} является {last}");
}
else
	System.Console.WriteLine("Это число не трехзначное");