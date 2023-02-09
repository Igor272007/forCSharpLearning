// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// А(3,6); B(2,1) -> 5.09
// A(7,- 5);bool(1,-1) -> 7,21
// корень((х1 - х2)^2 + (y1 - y2)^2)
// Math.Sqrt()
// Math.Pow(выражение, степень)

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

int x1 = GetNumber("введите координату Х первой точки");
int y1 = GetNumber("введите координату Y первой точки");

int x2 = GetNumber("введите координату Х второй точки");
int y2 = GetNumber("введите координату Y второй точки");

double GetDistance (int x1, int x2, int y1, int y2)//создаем функцию на поиск дистанции
{
    double result = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));//после запятой в скобках указана степень в которую возводим
    return result;
} 

System.Console.WriteLine(GetDistance(x1,x2,y1,y2));

