// Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }           
    Console.WriteLine();
}

int[,] CreateMassive(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int a = 1;
    int beginRows = 0;
    int endRows = rows-1;
    int beginColumns = 0;
    int endColumns = columns-1;
    
    while (beginColumns <= endColumns && beginRows <= endRows)
        for (int i = beginColumns; i <= endColumns; i++)
        {
            array[rows, columns] = a;
            a++;
        }
        beginRows++;
        for (int j = beginRows; j <= endRows; j++)
        {
            array[rows, columns] = a;
            a++;
        }
        endColumns--;
        for (int i = endColumns; i >= beginColumns; i--)
        {
            array[rows, columns] = a;
            a++;
        }
        endRows--;
        for (int j = endRows; j >= beginRows; j--)
        {
            array[rows, j] = a;
            a++;
        }
        beginColumns++;
    return array;
}


int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите число строк:  ");
int columns = EnterData("Введите количество столбцов:  ");
int[,] matrix = CreateMassive(rows, columns);
PrintArray(matrix);