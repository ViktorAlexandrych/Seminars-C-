// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
int numberA = 7;
int numberB = 23;
System.Console.WriteLine("Введи число: ");
int numberC = int.Parse(System.Console.ReadLine()!);
if (numberC % numberA == 0 && numberC % numberB == 0)
{
	System.Console.WriteLine($"Число {numberC} кратно {numberB}, {numberA}");
}
else
	System.Console.WriteLine($"Число {numberC} не кратно {numberB}, {numberA}");