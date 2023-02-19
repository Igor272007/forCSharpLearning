// напишите программу, которая будет преобразовывать
// десятичное число в двоичное
// 45 -> 101101
// 3 -> 11

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

void NumberTranslation(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    Console.WriteLine($"{result}");
}

int result = GetNumber("введите число: ");
NumberTranslation(result);