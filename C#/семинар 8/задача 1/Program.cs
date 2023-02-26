// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

int[,] InitMatrix()
{
    int[,] matrix = new int[5,4];
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

void ChangeMatrix(int[,] matrix)
{
    int numberJ = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        numberJ = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1, (j)];
        matrix[matrix.GetLength(0)-1, (j)] = numberJ;
    }
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
ChangeMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);