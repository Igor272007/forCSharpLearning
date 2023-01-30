// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю 
// цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");

string? numberStr = Console.ReadLine();

if (numberStr != null) {
    int number = Math.Abs(int.Parse(numberStr));
    Console.WriteLine(number%10);
}