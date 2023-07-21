// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowQuarter(int coordinates)
{
	if (coordinates == 1) Console.WriteLine("Диапозон точек на четверти x > 0, y > 0");
	if (coordinates == 2) Console.WriteLine("Диапозон точек на четверти x < 0, y > 0");
	if (coordinates == 3) Console.WriteLine("Диапозон точек на четверти x < 0, y < 0");
	if (coordinates == 4) Console.WriteLine("Диапозон точек на четверти x > 0, y < 0");
}

int GetInput(string text)
{
	Console.Write(text);
	return Convert.ToInt32(System.Console.ReadLine());
}

int coordinates = GetInput("Введите номер четверти: ");
ShowQuarter(coordinates);