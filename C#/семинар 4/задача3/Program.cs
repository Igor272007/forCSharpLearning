// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];

    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-100, 300);
    }

    return arr;
}

int GetCount(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=10 && arr[i]<=99)
            count++;
    }
    return count;
}

int[] arr = InitArray(10);
Console.WriteLine(string.Join(',', arr));
int count = GetCount(arr);

Console.WriteLine($"кол-во элементов в диапазоне [10, 99] = {count}");