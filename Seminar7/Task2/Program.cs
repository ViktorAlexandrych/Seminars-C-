// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = i + j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
			Array[i, j] = i + j;
			Console.Write($"{Array[i, j]} ");
		}

	}

}

massiv(rows, columns);