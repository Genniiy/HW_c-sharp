// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели   ");
int NumberDayOfWeek = int.Parse(Console.ReadLine());
if (NumberDayOfWeek < 1 || NumberDayOfWeek > 7)
{ 
    Console.WriteLine("Введен неправильный номер");
}
if (NumberDayOfWeek > 5)
{ 
    Console.WriteLine("да");
}
if (NumberDayOfWeek <= 5)
{ 
    Console.WriteLine("нет");
}