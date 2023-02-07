// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int numberRequest(string message)
{
     Console.WriteLine(message);
     int numberDay = Convert.ToInt32(Console.ReadLine());
     return numberDay;
}

int numberDay = numberRequest("введите номер дня недели от 1 до 7: ");

if (numberDay == 6 || numberDay == 7)
{
     Console.WriteLine("да");
}
else if (numberDay < 1 || numberDay > 7)
{
     Console.WriteLine("Вы ввели неверное число");
}
else
Console.WriteLine("нет");
