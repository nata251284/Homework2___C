/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int delete (int number)
{
int twoDigit = number %100;
int secondNumber = twoDigit /10;
int result = secondNumber;
return result; 
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (" ");
Console.WriteLine ("Вторая цифра трехзначного числа: " + $"{ delete (number)}");

