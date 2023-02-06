// задача. 
// напишите программу, которая принимает на вход два числа и определяет является
// ли второе кратным первому. если второе число не кратно первому, то второе
//число выводит остаток от деления

// Console.WriteLine("Введите число 1");
// Console.ReadLine();
// Console.WriteLine("Введите число 1");
// Console.ReadLine();    сделали через функцию

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = numberRequest("введите число 1");
int numberTwo = numberRequest("введите число 2");

if (numberOne % numberTwo == 0)
{
    Console.WriteLine("второе число кратно первому");
}
else
Console.WriteLine($"второе число не кратно первому. остаток от деления равен {numberOne % numberTwo}");
