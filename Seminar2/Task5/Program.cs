// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
System.Console.WriteLine("Введи первое число: ");
int numberA = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Введи второе число: ");
int numberB = int.Parse(System.Console.ReadLine()!);
int sqrA = numberA * numberA;
int sqrB = numberB * numberB;
if (sqrA == numberB)
{
	System.Console.WriteLine("Одно число считается квадратом другого");
}
else
if (sqrB == numberA)
{
	System.Console.WriteLine("Одно число считается квадратом другого");
}
else
	System.Console.WriteLine("Одно число не считается квадратом другого");
