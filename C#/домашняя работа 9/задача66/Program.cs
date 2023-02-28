// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int GetSumRec(int numberM, int numberN)
{
    if (numberM == numberN)
    return numberM;
    else
    {
        return numberN + GetSumRec(numberM, numberN - 1);
    }
}

int numberM = GetNumber("введите число: ");
int numberN = GetNumber("введите число: ");

Console.WriteLine(GetSumRec(numberM,numberN));