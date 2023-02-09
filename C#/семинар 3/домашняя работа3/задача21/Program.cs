// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//distanceBetweenpoint = sqrt((X2 - X1)^2 + (y2 - y1)^2 + (z2 - z1)^2)

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
int z1 = GetNumber("введите координату Z первой точки");

int x2 = GetNumber("введите координату Х второй точки");
int y2 = GetNumber("введите координату Y второй точки");
int z2 = GetNumber("введите координату Z второй точки");

double GetDistance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    return result;
} 

System.Console.WriteLine(GetDistance(x1,x2,y1,y2,z1,z2));
