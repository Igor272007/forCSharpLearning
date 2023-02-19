// Задача 40: Напишите программу, которая 
// принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая 
// сторона треугольника меньше суммы двух других сторон.

/*
алгоритм
1. принимает на вход 3 числа
2. проверяет каждая сторона треугольника должна 
быть меньше суммы двух других сторон.
*/

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

void Checkside(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("треугольник с такими сторонами может существовать");
    }
    else Console.WriteLine("треугольник с такими сторонами невозможен");
}
int a = GetNumber("введите первое число: ");
int b = GetNumber("введите второе числов ");
int c = GetNumber("введите третье число ");

Checkside(a,b,c);