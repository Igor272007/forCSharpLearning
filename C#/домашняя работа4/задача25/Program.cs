// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int numberA = GetNumber("введите число А");
int numberB = GetNumber("введите число B");

int AToPowOfB = numberA;

for (int i = 1; i < numberB; i++)
{
    AToPowOfB = AToPowOfB * AToPowOfB;
}
Console.WriteLine($"{numberA}, {numberB} -> {AToPowOfB}");
