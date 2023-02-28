// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int AkkermanFunc(int numberN, int numberM)
{
  if (numberN == 0)
    return numberN + 1;
  else
    if ((numberN != 0) && (numberM == 0))
      return AkkermanFunc(numberN - 1, 1);
    else
      return AkkermanFunc(numberN - 1, AkkermanFunc(numberN, numberM - 1));
}

int numberM = GetNumber("введите число: ");
int numberN = GetNumber("введите число: ");

Console.WriteLine(AkkermanFunc(numberN, numberM));

