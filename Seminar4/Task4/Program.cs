﻿// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]




int[] randomArray = new int[8];
for (int i = 0; i < 8; i++)
{
	randomArray[i] = new Random().Next(2);
	Console.Write($"[{String.Join("", randomArray[i])}]");
}