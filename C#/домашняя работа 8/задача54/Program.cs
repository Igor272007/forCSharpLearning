// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InitMatrix()
{
    int[,] matrix = new int[3,4];
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

static void BubbleSort(int[] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (matrix[j] < matrix[j + 1])
                    {
                        int temp = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = temp;
                    }
                }
    }

void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);

void ChangeMatrix(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            row[j] = matrix[i,j];
        BubbleSort(row);
        Insert(true, i, row, matrix);
    }   
}

ChangeMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

