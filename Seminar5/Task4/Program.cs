// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void GetSearchArray(int[] randomArray)
{
	int rangeA = 9;
	int rangeB = 100;
	int count = 0;
	for (int i = 0; i < randomArray.Length; i++)
	{
		if (randomArray[i] > rangeA && randomArray[i] < rangeB)
		{
			count += 1;
		}
	}
	Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10,99]: " + count);

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
int[] randomArray = GenerateRandomArray(a, 1, 150);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", randomArray)}]");
GetSearchArray(randomArray);
