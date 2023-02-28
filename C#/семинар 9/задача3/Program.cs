// Задача 67: Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

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

int GetNaturalNumbersRec(int number, int sumOfDigit)
{
    if (number == 0)
    return sumOfDigit;
    else
    {
        sumOfDigit += number % 10;
        number /= 10;
        return GetNaturalNumbersRec(number, sumOfDigit);
    }
}
int number = GetNumber("введите число: ");
int sumOfDigit = 0;
Console.WriteLine(GetNaturalNumbersRec(number, sumOfDigit));