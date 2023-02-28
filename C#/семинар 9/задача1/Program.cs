// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result !=0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Повторите ввод");
        }
    }

    return result;
}

string GetNaturalNumbersRec(int number)
{
    if (number == 1)
    return "1";
    return GetNaturalNumbersRec(number - 1) + " " + number.ToString();
}

int number = GetNumber("введите число: ");
Console.WriteLine(GetNaturalNumbersRec(5));