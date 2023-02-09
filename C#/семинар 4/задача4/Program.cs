// Задача 37: Найдите произведение пар чисел 
// в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] GetResultArray(int[] array)
{
    int [] result;
    if (array.Length % 2 == 0)
    {
        result = new int [array.Length / 2];

    }

    else
    {
        result = new int [array.Length / 2 +1];
    }

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length -i -1];
    }
    if (array.Length % 2 != 0)
    {
        result[result.Length -1] = array[array.Length/2];
    }
    return result;

}

int[] array = InitArray(); 
PrintArray(array);
int[] result = GetResultArray(array);
PrintArray(result);