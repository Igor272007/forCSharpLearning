// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20

int[] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetPositiveSum(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sum += array[i];
    }
    return sum;
}

int GetNegativeSum(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}

int[] arr = InitArray();
PrintArray(arr);
int posSum = GetPositiveSum(arr);
int negSum = GetNegativeSum(arr);

Console.WriteLine($"сумма положительных элементов = {posSum}, отрицательных = {negSum}");

//если массив большой, создают класс, см в задаче 2
