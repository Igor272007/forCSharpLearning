// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int numberRequest(string message)
{
     Console.WriteLine(message);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}

int number = numberRequest("введите номер дня недели от 1 до 7: ");

Console.WriteLine((number > 5 && number < 8) ? ("да") : ("нет"));
