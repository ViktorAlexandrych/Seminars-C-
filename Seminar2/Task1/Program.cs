// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// System.Console.WriteLine("Генерируем 2 числа, подождите...");

// int numberA = new Random().Next(10, 100);
// int numberB = new Random().Next(10, 100);
// int max = numberA;
// System.Console.WriteLine("Первое число: " + numberA);
// System.Console.WriteLine("Второе число: " + numberB);

// System.Console.WriteLine("Ищем наибольшее из них...");
// if (max < numberB)
// {
// 	max = numberB;
// }

// System.Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine("Генерируем число, подождите...");
int number = new Random().Next(10, 100);
Console.WriteLine("Сгенерированное число: " + number);
int FirstDigit = number / 10;
int SecondDigit = number % 10;
int max = FirstDigit;
Console.WriteLine("Сравниваем цифры в числе...");
if (max < SecondDigit)
{
	max = SecondDigit;
}
Console.WriteLine("Наибольшее цифра в этом числе: " + max);
