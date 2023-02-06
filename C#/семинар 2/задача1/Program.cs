/*
вычислите максимальное число трехзначного числа и удалите его

алгоритм
1. получить рандомное число в диапазоне [1, 999]
2. получить вторую цифру числа (или первую и третью)
3. удалить его (составить число из первого и третьего)

*/
//часть 1
int GetNumber() // часть 1
{
    Random rnd = new Random();
    int result = rnd.Next(1, 1000);
    return result;
}
//часть 2
int GetDeleteOfSecondNumber(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return firstDigit * 10 + thirdDigit;
}

//часть 3
int number = GetNumber();
int result = GetDeleteOfSecondNumber(number);

Console.WriteLine($"трехзначное число после удаления второй цифры равно {number} = {result}");