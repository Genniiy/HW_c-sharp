// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число  ");

string s = Console.ReadLine();
int a = int.Parse(s);

if (a < 99 || a > 999) {
    Console.WriteLine("Ваше число не трехзначное, введите трехначное число");
}

else {
    Console.WriteLine(Convert.ToString(s[1]));
} 