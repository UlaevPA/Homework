﻿//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 3 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int overNumber = number1;

if (overNumber < number2)
{
    overNumber = number2;

}
if (overNumber < number3)
{
    overNumber = number3;
}


Console.WriteLine($"Наибольшее число {overNumber}");