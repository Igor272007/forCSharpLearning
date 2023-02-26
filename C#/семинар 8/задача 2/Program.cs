// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.

int[,] InitMatrix()
{
    int[,] matrix = new int[3,5];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,10);
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

int[,] ChangeMatrix(int[,] matrix)
{
    int[,] change = new int [matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            change[i,j] = matrix[j,i];
        }
    }
    return change;
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
int[,] change = ChangeMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(change);