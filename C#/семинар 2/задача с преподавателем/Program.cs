/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

например: 
78 -> 8
12 -> 2
85 -> 8

алгоритм
1. получить рандомное число в диапазоне [1, 99]
2. получить максимальную цифру числа
*/

int GetNumber() // часть 1
{
    Random rnd = new Random();
    int result = rnd.Next(1, 100); // [left, right] правое нестрого, левое строго -> [10, 100) -> [10, 99]
    return result;
}

// часть 2
int GetMaxDigOfNumber(int number) // задаем функцию. Все кроме void содержит return, т.е. что-то возвращает
//если мы хотим, чтобы ничего не возвращалось, то используем void (в данном случае вместо int)
//после наименования функции всегда идут круглые скобки, вне зависимости от того, передаем мы туда 
// параметры или нет. без параметров - пустые скобки, с параметрами - внутри скобок.
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigOfNumber(number);

Console.WriteLine($"максимальная цифра числа {number} = {maxDigit}");