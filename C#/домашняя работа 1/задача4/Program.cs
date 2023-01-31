// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число номер 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число номер 2:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число номер 3:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;

if (number1 > number2)
{
    max = number1;
}
else if (number1 == number2)
{
    max = number1;
}
else
{
     max = number2;
}
if (max > number3)
{
    Console.WriteLine(max);
}
else
{
    Console.WriteLine(number3);
}