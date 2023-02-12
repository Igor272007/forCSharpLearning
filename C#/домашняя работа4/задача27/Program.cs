// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

int number = GetNumber("введите число:");

char[] numberAsArray = number.ToString().ToArray();

int sumOfDigits = 0;
int a;

for (int i = 0; i < numberAsArray.Length; i++)
{
    a = numberAsArray[i] - '0';
    sumOfDigits = sumOfDigits + a;
}

Console.WriteLine($"{number} -> {sumOfDigits}");
