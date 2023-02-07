// напишите программу, которая принимает на вход координаты точки (Х и Y),
// причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.
//            Y
//     2      |    1
//            |
// ---------------------->x
//            |0
//     3      |      4
//            |

// 1. получить x и y с консоли
// 2. получить номер четверти, где лежит точка с координатами(х и у)
// 3. вывести результат на экран

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

int GetQuarter( int x, int y)
{
    if(x > 0 && y > 0)
    return 1;
    else if(x < 0 && y > 0)
    return 2;
    else if(x < 0 && y < 0)
    return 3;
    else
    return 4;
}

int x = GetNumber("введите х отличный от нуля");
int y = GetNumber("Введите y отличный от нуля");
int quarter = GetQuarter(x, y);

Console.WriteLine($"точка с координатами ({x}, {y} лежит в {quarter} четверти)");

/*
1. reference type (ссылочные типы)
class, array, list, char
(хранятся в управляемой кучи)
работаем с их ссылками

2. value types (значимые типы)
int, double,float, decimal, long, bit, byte, struct, enum, datetime
(хранятся в стеке - оперативная память компьютера/сервера/выделяемая память на облаке)
работаем с их значениями
*/

// void Temp(out int x) //out требует инициализации переменное (ниже x = 2), в то время как ref
// // (можно поставить на место out в скобки) не требует инициализации и может брать значения извне
// // (т.е. выражение x = 2 в случае использования ref на месте out не обязательно)
// {
//     x = 2;
//     x = x * 10;
//     Console.WriteLine($"x внутри метода = {x}");
// }

// void Temp1(int[] arr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(1, 10);
//     }
// }

// int x = 5;
// Temp(ref x);

// Console.WriteLine($"x снаружи метода {x}");
// int [] array = new int[8]; //целочисленный массив с 8 элементами
// Console.Write(string.Join(",", array));
// Temp1(array);
// Console.WriteLine();
// Console.Write(string.Join(",", array));