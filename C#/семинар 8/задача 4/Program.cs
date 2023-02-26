// задача 57. составьте частотный словарь данных элементов
// двумерного массива. частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных

// {1, 9, 9, 0, 2, 8, 0, 9}
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

int[,] InitArray()
{
    int[,] result = new int[4,4];
    Random rnd = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rnd.Next(1,10);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)  //почитать о словарях
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}");
        }
        Console.WriteLine();
    }
}

// Dictionary<int, int> dic = new Dictionary<int, int>(); //это как задается. значения и ключи уникальны и не повторяются.

// dic.Add(1,2);
// dic.Add(1,4); - будет неверно так как на прошлой строке ключ был задан

Dictionary<int, int> GetDictionary(int[,] matrix)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(dic.ContainsKey(matrix[i,j]))
            {
                dic[matrix[i,j]]++;
            }
            else
            {
                dic.Add(matrix[i,j], 1);
            }
        }
    }
    return dic;
}

int[,] matrix = InitArray();
PrintMatrix(matrix);

Dictionary<int, int> dic = GetDictionary(matrix);

foreach(var item in dic.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раз");
}