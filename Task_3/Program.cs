// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Array(int[,] matrix1, int[,] matrix2, int rows, int columns)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Действие невозможно");
    }
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix3;
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
int[,] matrix1 = CreateMassive(rows, columns, 1, 4);
int[,] matrix2 = CreateMassive(rows, columns, 1, 4);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
int[,] matrix3 = Array(matrix1, matrix2, rows, columns);
PrintArray(matrix3);