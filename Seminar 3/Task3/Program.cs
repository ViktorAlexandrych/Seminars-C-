// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09      d = √ (х А – х В) 2 + (у А – у В) 2
// A(7, -5); B(1, -1)-> 7,21

void ShowQuarter(int xA, int yA, int xB, int yB)
{
	double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
	System.Console.WriteLine($"Расстояние между точек X и Y: {distance}");
}

int GetInput(string text)
{
	Console.Write(text);
	return Convert.ToInt32(System.Console.ReadLine());
}

int xA = GetInput("Введите координаты A точки X: ");
int yA = GetInput("Введите координаты A точки Y: ");
int xB = GetInput("Введите координаты B точки X: ");
int yB = GetInput("Введите координаты B точки Y: ");
ShowQuarter(xA, yA, xB, yB);