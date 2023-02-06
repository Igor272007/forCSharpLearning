Console.WriteLine("введите число");
string numberStr = Console.ReadLine(); //
int number = Convert.ToInt32(numberStr); // "2232" -> 2232 convert - класс ToInt - метод. Из строчного типа 
переводят в числовой

int result = number * number;

Console.WriteLine($"квадрат числа {number} = {result}"); // разный вариант вывода со знаком $. с $ выводит подменяя названия переменных на их значение
Console.WriteLine("квадрат числа {number} = {result}"); // без знака $ просто переписывает строку в том виде, в каком она записана
Console.WriteLine("квадрат числа {0} = {1}", number, result);
Console.WriteLine("квадрат числа " + numberStr +" = " + result);
