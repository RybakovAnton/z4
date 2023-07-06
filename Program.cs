// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());

int num = number;

if (num<number2)
{
    num = number2;
}
if (num<number3)
{
    num = number3;
}
Console.WriteLine(num);
