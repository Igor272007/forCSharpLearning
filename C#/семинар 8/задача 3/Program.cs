// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец (первое попадание), 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] InitMatrix()
{
    int[,] matrix = new int [3,4];
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

(int, int) FindIndexOfMin(int[,] matrix) // вроде как кортеж. Прочитать по ним
{
    int min = matrix[0,0];
    int indexIOfMin = 0;
    int indexJOfMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(min > matrix[i, j])
            {
                min = matrix[i, j];
                indexIOfMin = i;
                indexJOfMin = j;
            }
        }
    }
    return (indexIOfMin, indexJOfMin);
}

int[,] ResultMatrix(int[,] matrix, int indexIOfMin, int indexJOfMin)
{
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)-1];
    int countI = 0;
    int countJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i == indexIOfMin)
        {
            continue;
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != indexIOfMin && j != indexJOfMin)
            {
                resultMatrix[countI, countJ] = matrix[i,j];
                countJ++;
            }
        }
        countJ = 0;
        countI++;
    }
    return resultMatrix;
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
(int indexIOfMin, int indexJOfMin) = FindIndexOfMin(matrix);
Console.WriteLine($"{indexIOfMin} {indexJOfMin}");
Console.WriteLine();
PrintMatrix(ResultMatrix(matrix, indexIOfMin, indexJOfMin));


