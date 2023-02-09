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
    Console.WriteLine();
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

Amounts GetAmounts(int[] array)
{
    Amounts item = new Amounts();

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            item.Negative += array[i];
        else
            item.Positive += array[i];
    }

    return item;
}
(int, int) GetSumms(int [] array)
{
    int negative = 0;
    int positive = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negative += array[i];
        else
            positive += array[i];
    }

    return (negative, positive);
}



int[] arr = InitArray();
PrintArray(arr);
int posSum = GetPositiveSum(arr);
int negSum = GetNegativeSum(arr);

Amounts item = GetAmounts(arr);

(int negative, int positive) = GetSumms(arr);

Console.WriteLine($"Сумма положительных элементов = {posSum}, отрицательных = {negSum}");
Console.WriteLine($"Сумма положительных элементов = {item.Positive}, отрицательных = {item.Negative}");
Console.WriteLine($"Сумма положительных элементов = {positive}, отрицательных = { negative}");




class Amounts
{
    internal int Negative{get;set;}
    internal int Positive {get;set;}
}
