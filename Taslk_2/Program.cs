// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinString(int[] sum, int choice)
{
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] == choice)
        {
            Console.WriteLine($" Наименьшая сумма находится в {i+1} строке");   
        }
    }
}

int MinSumString(int[] sum)
{
    int min = sum[0];
    for (int j = 0; j < sum.Length; j++)
    {
        if (min > sum[j])
        {
            min = sum[j];
        }
    }
    return min;
}

int[] StringSum(int[,] matrix, int rows, int columns)
{
    int[] temp = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        temp[i] = sum;
    }
    Console.WriteLine(String.Join("," , temp));
    return temp;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");          
        }
        Console.WriteLine();
    }
}

int[,] CreateMassive(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);            
        }
    }
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
int[,] matrix = CreateMassive(rows, columns, 0, 10);
PrintArray(matrix);
int[] sum = StringSum(matrix, rows, columns);
int choice = MinSumString(sum);
MinString(sum, choice);