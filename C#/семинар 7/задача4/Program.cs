// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] InitMatrix()
{
    int[,] matrix = new int[4,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(-1000,1000);
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


int FindSumElement (int[,] matrix)
{
    int sumOfNumbers = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
               sumOfNumbers = sumOfNumbers + matrix[i,j] ;
            }
        }
    }
    return sumOfNumbers;
}
int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine();
int sumOfNumbers = FindSumElement(matrix);
Console.WriteLine($"сумма элементов главной диагонали массива равна {sumOfNumbers}");