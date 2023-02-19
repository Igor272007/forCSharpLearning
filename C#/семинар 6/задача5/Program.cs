// напишите программу, которая будет 
// создавать копию заданного массива
// с помощью поэлементного копирования.

int[] InitArray()
{
    int[] result = new int[6];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,9);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int [] CopyArray(int[] array)
{
    int[] result = new int[6];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result; 
}
int[] array = InitArray();
PrintArray(array);
int[] result = CopyArray(array);
PrintArray(result);