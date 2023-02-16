// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray(int randomArray)
{
    int[] arr = new int[randomArray];

    Random rnd = new Random();

    for (int i = 0; i < randomArray; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }

    return arr;
}

int GetCount(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
            count++;
    }
    return count;
}

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest("введите количество элементов массива: ");


int[] arr = InitArray(number);
Console.WriteLine(string.Join(',', arr));
int count = GetCount(arr);

Console.WriteLine($"кол-во четных элементов в массиве = {count}");