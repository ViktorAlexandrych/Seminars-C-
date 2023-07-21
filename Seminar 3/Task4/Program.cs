// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


void ShowQuarter(int number)
{
	Console.WriteLine("Все квадраты чисел в промежутке от 1 до N: ");
	for (int i = 0; i < number; i++)
	{
		Console.Write(i * i + ", ");
	}
	Console.Write(number * number + ".");
}

int GetInput(string text)
{
	Console.Write(text);
	return Convert.ToInt32(System.Console.ReadLine());
}

int number = GetInput("Введите число: ");
ShowQuarter(number);