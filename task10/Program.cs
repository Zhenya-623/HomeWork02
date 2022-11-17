/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/

int SecondDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра введенного вами числа равна {result}");