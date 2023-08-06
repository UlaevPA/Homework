// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
int Even(int num)
{
    return num % 2;
} 

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int even = Even(num);
// if (even == 0)
// {
// Console.WriteLine("четное");
// }
// else 
// {
// Console.WriteLine("не четное");
// }

Console.WriteLine( even == 0? "Четное" : "Не четное");
