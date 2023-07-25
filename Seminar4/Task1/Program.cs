// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int limit)
{
	int sum = 0;
	for (int i = 1; i <= limit; i++)
	{
		sum += i;
	}
	return sum;
}

int GetInput(string text)
{
	Console.Write(text);
	return Convert.ToInt32(System.Console.ReadLine());
}

int numberA = GetInput("Введи число: ");
System.Console.WriteLine($"Сумма чисел от 1 до {numberA}: {GetSum(numberA)}");