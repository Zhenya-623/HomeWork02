﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("вы ввели не верное значение");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("да");
}
if (number >= 1 && number <= 5)
{
    Console.WriteLine("нет");
}