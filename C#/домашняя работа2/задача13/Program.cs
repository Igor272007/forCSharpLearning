// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest("введите число: ");

char[] numberAsArray = number.ToString().ToArray();

if (numberAsArray.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
Console.WriteLine(numberAsArray[2]);