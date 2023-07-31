// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

System.Console.WriteLine("Введите число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void massiv(int m, int n)
{
	int i, j;
	Random rand = new Random();
	for (i = 0; i < m; i++)
	{
		Console.WriteLine();
		for (j = 0; j < n; j++)
		{
			randomArray[i, j] = rand.Next(1, 100);
			Console.Write($"{randomArray[i, j]} ");
		}

	}

}

massiv(m, n);