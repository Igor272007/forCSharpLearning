// задача 46. задайте двухмерный массив размером M*N, 
// заполненный случайными числами.
// m = 3, n = 4;
// 1 4 8 19
// 5 -3 33 -2
// 77 3 9 1

int[,] InitMatrix()
{
    int[,] matrix = new int[3,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(-100,100);
        }
    }
    return matrix;
}

void PritMatrix(int[,] matrix)
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
PritMatrix(matrix);