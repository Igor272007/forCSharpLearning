// напишите программу, которая принимает на вход число (N) и выдает таблицу
// чисел, возведенных в  квадрат от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4
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

int numberN = GetNumber("введите число");

for (int i = 1; i <= Math.Abs(numberN); i++)// Math.Abs() - все, что в скобках попадает берется в модуле
{
    Console.Write($"{Math.Pow(i,2)} ");
}
