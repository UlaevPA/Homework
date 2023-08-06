//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Ведите натуральное число N");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;
if (number < 0)
{
    Console.Write("Введено некорректное число.");
}
while (startNumber <= number)
{
    if (startNumber % 2 == 0)
    {
        Console.WriteLine($"Четные:  {startNumber}");
        startNumber +=2;
    }
    else
    {
    startNumber +=1;
    }
}
