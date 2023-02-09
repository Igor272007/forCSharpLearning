// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
char[] numberAsArray = number.ToString().ToArray();

if(numberAsArray.Length == 5)
{
    if(numberAsArray[0] == numberAsArray[4] && numberAsArray[1] == numberAsArray[3])
    {
        Console.WriteLine("это число - Палиндром");
    }
    else
    {
    Console.WriteLine("это число не Палиндром");
    }
}
else
Console.WriteLine("Вы ввели неверные данные");




// int numberRequest(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int number = numberRequest("введите пятизначное число");


// if numberAsArray == 
