// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.






int GetSumPosOrNeg(int[] randomArray, bool PositiveOrNegative)
{
	int sum = 0;
	for (int i = 0; i < randomArray.Length; i++)
	{
		if (PositiveOrNegative)
		{
			if (randomArray[i] > 0)
				sum += randomArray[i];
		}
		else
		{
			if (randomArray[i] < 0)
				sum += randomArray[i];
		}
	}
	return sum;
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

int[] randomArray = GenerateRandomArray(12, -9, 9);
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", randomArray)}]");
Console.WriteLine($"Сумма положительных чисел равна {GetSumPosOrNeg(randomArray, true)}");
Console.WriteLine($"Сумма отрицательных чисел равна {GetSumPosOrNeg(randomArray, false)}");