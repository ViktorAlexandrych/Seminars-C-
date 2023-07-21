// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine("Генерируем случайное трехзначное число: " + number);
int first = number / 100;
int second = number % 10;
Console.WriteLine("Удаляем вторую цифру этого числа");
int newnumber = first * 10 + second;
Console.WriteLine("Результат: " + newnumber);