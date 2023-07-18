// 1. Надо попросить ввести число
// 2. Записать число в переменную
// 3. Перемножить 2 числа и записать в новую переменную
// 4. Вывести результат
Console.Write("Введи число: ");

double number = double.Parse(Console.ReadLine()!);
double result = number * number;
Console.WriteLine("Квадрат числа вашего числа равен: " + result);
