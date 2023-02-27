// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] InitMatrix()
{
    int[,] matrix = new int[4,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);

int sumOfLine = 0;
int [] number = new int[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumOfLine += matrix[i,j];
        
    }
    number[i] = sumOfLine;
    Console.WriteLine(); 
    Console.Write($"сумма строки {i + 1} равна {sumOfLine} ");
    
}



int FindMinNumber(int[] number)
{
    int minNumber = 0;
    int numberOfMinLine = 1;
    for (int i = 0; i < number.Length - 1; i++)
    {
        if(number[i] > number[(i + 1)])
        {
            minNumber = number[i];
            numberOfMinLine = i;
        }
    }
    return numberOfMinLine;
    
}

int numberOfMinLine = FindMinNumber(number);
Console.WriteLine();
Console.WriteLine($"{numberOfMinLine} строка");