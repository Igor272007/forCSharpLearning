// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное 
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

//!!! break выходим из цикла, в котором эта команда записана
//!!! return - выходим из функции

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

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

void SearchNumber(int[] array,int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Число {number} есть в масиве.");
            return;
        }
        

        
    }

    Console.WriteLine($"Числа {number} нет в массиве.");

}

int[] array = InitArray();
PrintArray(array);
int number = GetNumber("Введите целое число: ");
SearchNumber(array,number);