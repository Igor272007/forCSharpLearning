// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

double[] InitArray(int randomArray)
{
    double[] arr = new double[randomArray];

    Random rnd = new Random();

    for (int i = 0; i < randomArray; i++)
    {
        arr[i] = rnd.Next(0, 1000);
    }

    return arr;
}

double numberRequest(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
double number = numberRequest("введите количество элементов массива: ");

double[] arr = InitArray(Convert.ToInt32(number));
Console.WriteLine(string.Join(',', arr));

double min = arr[0];
double max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if(min > arr[i])
    {
        min = arr[i];
        i++;
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if(max < arr[i])
    {
        max = arr[i];
        i++;
    }
}

// double max = arr.Max();
// double min = arr.Min();

Console.WriteLine($"разница между минимальным и максимальным элементами массива = {max - min}");