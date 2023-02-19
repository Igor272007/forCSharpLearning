// Задача 44: Не используя рекурсию, выведите 
// первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

void FibonacciNumber(int number)
{
    int fibNumberOne = 0;
    int fibNumberTwo = 1;
    int SumNumber = 0;

    if (number == 1)
    {
        fibNumberTwo = 0;
        Console.WriteLine(fibNumberTwo);
    }
    else
    {
        fibNumberTwo = 1;
        Console.Write("0 1 ");
        for (int i = 0; i < number - 2; i++)
        {
            SumNumber = fibNumberOne + fibNumberTwo;
            fibNumberOne = fibNumberTwo;
            fibNumberTwo = SumNumber;
            Console.Write($"{SumNumber} ");
        }
    }
}

int result = GetNumber("введите положительное число");
FibonacciNumber(result);