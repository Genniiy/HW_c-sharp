// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число     ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число     ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число     ");
int number3 = int.Parse(Console.ReadLine());

if (number > number2 && number > number3)
{
    Console.WriteLine($"max = {number}");
}

if (number2 > number && number2 > number3)
{
    Console.WriteLine($"max = {number2}");
}

if (number3 > number && number3 > number2)
{
    Console.WriteLine($"max = {number3}");
}