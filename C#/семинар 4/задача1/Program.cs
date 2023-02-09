// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] InitArray()
{
    int[] result = new int[12];
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
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ChangeArray (int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = array[i]*-1;
    }    
}

int [] massive = InitArray();
PrintArray (massive);

ChangeArray (massive);
PrintArray (massive);