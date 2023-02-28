// задача 69. Напишите программу, которая
// на вход принимает два числа А и В, возводит 
// число А в степень В с помощью рекурсии.
// А = 3; В = 5 - > 243(3)
// A = 2; B = 3 -> 8(2)

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

int GetPowNumbersRec(int numberA, int numberB)
{
    if (numberB == 1)
    return numberA;
    else
    {
        return numberA * GetPowNumbersRec(numberA, numberB - 1);
    }
}

int numberA = GetNumber("введите число: ");
int numberB = GetNumber("введите число: ");

Console.WriteLine(GetPowNumbersRec(numberA, numberB));