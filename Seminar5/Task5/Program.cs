// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21




void GetFindProduct(int[] randomArray)
{
	for (int i = 0; i < randomArray.Length / 2; i++)
	{
		Console.Write(+randomArray[i] * randomArray[randomArray.Length - 1 - i] + " ");
	}
	if (randomArray.Length % 2 == 1)
	{
		Console.WriteLine(randomArray[randomArray.Length / 2]);
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
int[] randomArray = GenerateRandomArray(a, 1, 10);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", randomArray)}]");
GetFindProduct(randomArray);