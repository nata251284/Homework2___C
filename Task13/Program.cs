/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6  */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string ThreeDigit = Convert.ToString(number);

if (ThreeDigit.Length > 2)
Console.WriteLine ("Третья цифра заданного числа: " + $"{ ThreeDigit[2] }");

else Console.WriteLine ("Третьей цифры у данного числа нет.");

