/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

while (number > 999)
{
    number = number / 10;
}

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Третья цифра введенного вами числа равна {number % 10}");
}
else
    Console.WriteLine($"Третьей цифры нет");
