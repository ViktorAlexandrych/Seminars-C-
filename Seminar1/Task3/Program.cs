// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
System.Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.WriteLine("Сегодня понедельник");
if (number == 2) Console.WriteLine("Сегодня вторник");
if (number == 3) Console.WriteLine("Сегодня среда");
if (number == 4) Console.WriteLine("Сегодня четверг");
if (number == 5) Console.WriteLine("Сегодня пятница");
if (number == 6) Console.WriteLine("Сегодня суббота");
if (number == 7) Console.WriteLine("Сегодня воскресенье");