// задача 65. задайте значения M и N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1,2,3,4,5"
// M = 4; N = 8 -> "4,6,7,8"

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

string GetNaturalNumbersRec(int numberM, int numberN)
{
    if (numberM == numberN)
    return numberM.ToString();
    return (numberM.ToString())+ " "+ GetNaturalNumbersRec(numberM + 1, numberN);
}

int numberM = GetNumber("введите число: ");
int numberN = GetNumber("введите число: ");

Console.WriteLine(GetNaturalNumbersRec(numberM,numberN));