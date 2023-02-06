//напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно и 7 и 23.

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest("введите число: ");

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("введенное число кратно 7 и 23");
}
else 
Console.WriteLine($"введенное число не кратно одновременно 7 и 23");




