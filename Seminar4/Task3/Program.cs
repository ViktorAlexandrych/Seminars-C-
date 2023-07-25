// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int GetIncrease(int limit)
{
	int increase = 1;
	for (int i = 1; i <= limit; i++)
	{
		increase = increase * i;
	}
	return increase;
}

int GetInput(string text)
{
	Console.Write(text);
	return Convert.ToInt32(System.Console.ReadLine());
}

int number = GetInput("Введи число: ");
int result = GetIncrease(number);
System.Console.WriteLine($"Произведение чисел от 1 до {number}: {result}");