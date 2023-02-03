// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число  ");

string s = Console.ReadLine();
int a = int.Parse(s);
if (a < 99) {
    Console.WriteLine("третьей цифры нет");
}
Console.WriteLine(Convert.ToString(s[2]));
 