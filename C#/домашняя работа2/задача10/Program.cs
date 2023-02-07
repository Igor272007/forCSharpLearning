// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest("введите трехзначное число: ");

int secondDigit = number / 10 % 10;

Console.WriteLine(secondDigit);
