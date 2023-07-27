// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void GetChangeArray(int[] randomArray)
{
	for (int i = 0; i < randomArray.Length; i++)
	{
		randomArray[i] = -1 * randomArray[i];
	}
	Console.WriteLine($"Измененный массив: [{String.Join(", ", randomArray)}]");
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

Console.WriteLine("Введите число элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = GenerateRandomArray(a, -999, 999);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", randomArray)}]");
GetChangeArray(randomArray);
