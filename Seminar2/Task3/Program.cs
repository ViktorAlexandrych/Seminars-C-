// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Write("Введи первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введи второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
int segmentationA = 0;
if (numberA % numberB == segmentationA)
{
	System.Console.WriteLine($"Число {numberB} кратно числу {numberA}, остаток от деления => {segmentationA}");
}
else
{
	int segmentationB = numberA % numberB;
	System.Console.WriteLine($"Число {numberB} не кратно числу {numberA}, остаток от деления => {segmentationB}");
}
