// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой 
// четверти (x и y).

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result < 5 && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или неверное число. Повторите ввод");
        }
    }

    return result;
}

void GetQuarter( int x)
{
    if(x == 1)
Console.WriteLine("Значения Х > 0 && Y > 0");
    else if(x == 2)
    Console.WriteLine("Значения Х < 0 && Y > 0");
    else if(x == 3)
    Console.WriteLine("Значения Х < 0 && Y < 0");
    else
    Console.WriteLine("Значения Х > 0 && Y < 0");
}

int x = GetNumber("введите четверть");
GetQuarter(x);
