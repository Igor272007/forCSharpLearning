// Задача 39: Напишите программу, которая 
// перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] InitArray(int dimension)
{
    int[] result = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for(int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }

    return result;
}

int[] array = InitArray(10);
PrintArray(array);
int[] result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result); //встроенная функция
PrintArray(result);
