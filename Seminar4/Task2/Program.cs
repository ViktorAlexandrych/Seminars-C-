// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetCountNumber(int value)
{
	int count = 0;
	while (value > 0)
	{
		value /= 10;
		count++;
	}
	return count;
}

int GetInput(string text)
{
	Console.Write(text);
	return Convert.ToInt32(System.Console.ReadLine());
}

int number = GetInput("Введи число: "); //Ввели число

int result = GetCountNumber(number); //Посчитали сколько цифр

Console.WriteLine($"Колличество цифр в данном числе: {result}"); //Вывели результат