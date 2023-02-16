// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] InitArray(int randomArray)
{
    int[] arr = new int[randomArray];

    Random rnd = new Random();

    for (int i = 0; i < randomArray; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }

    return arr;
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

int sumOfElements = 0;

for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        sumOfElements = sumOfElements + arr[i];
    }

Console.Write($" -> {sumOfElements}");
