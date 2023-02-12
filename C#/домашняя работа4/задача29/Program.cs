// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int number = 8;

int[] InitArray(number)
{
    int[] arr = new int[number];

    Random rnd = new Random();

    for (int i = 0; i < number; i++)
    {
        arr[i] = rnd.Next();
    }

    return arr;
}

int[] arr = InitArray(4);

Console.WriteLine(arr);

