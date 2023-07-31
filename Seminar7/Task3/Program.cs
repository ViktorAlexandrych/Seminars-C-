// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.



System.Console.WriteLine("Введите число столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число строк: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[rows, columns];

void massiv(int rows, int columns)
{
	int i, j;
	for (i = 0; i < rows
; i++)
	{
		Console.WriteLine();
		for (j = 0; j < columns; j++)
		{
			if (i % 2 == 0 & j % 2 == 0)
			{
				Array[i, j] = Array[i, j] * Array[i, j];
			}
			Array[i, j] = new Random().Next(1, 3);
			Console.Write($"{Array[i, j]} ");
		}

	}

}

massiv(rows, columns);