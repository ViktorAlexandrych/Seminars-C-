// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// - 3; массив[6, 7, 19, 345, 3]->да





void GetSearchArray(int[] randomArray, int num)
{
	for (int i = 0; i < randomArray.Length; i++)
	{
		if (randomArray[i] == num)
		{
			Console.WriteLine("Заданное число присутствует в массиве");
		}
		else Console.WriteLine("Заданного числа нет в массиве");
		break;
	}
}

int[] GenerateRandomArray(int elements, int start, int finish)
{
	int[] randomArray = new int[elements];
	for (int i = 0; i < elements; i++)
	{
		randomArray[i] = new Random().Next(start, finish + 1);
	}
	return randomArray;
}

Console.Write("Введите число элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = GenerateRandomArray(a, -999, 999);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", randomArray)}]");
Console.Write("Введите искомый элемент массива: ");
int num = Convert.ToInt32(Console.ReadLine());
GetSearchArray(randomArray, num);