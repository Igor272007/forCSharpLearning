//напишите программу, которая принимает на вход 2 числа и проверяет, является ли одно из них квадратом другого

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = numberRequest("введите число 1");
int numberTwo = numberRequest("введите число 2");

if (numberOne * numberOne == numberTwo)

// if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
// {
//      Console.WriteLine("одно из введенных чисел является квадратом другого");
// }

{
    Console.WriteLine("второе число равно квадрату первого");
}
else if (numberTwo * numberTwo == numberOne)
{
    Console.WriteLine("первое число равное квадрату первого");
}
else
Console.WriteLine("первое и второе число не являются квадратами друг друга");

