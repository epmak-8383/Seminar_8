// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {   
                Console.Write($"{arr[i, j, k]}{(i, j, k)}");
            }
            Console.WriteLine();
        }           
    }
    Console.WriteLine();
}

int[,,] CreateMassive(int rows, int columns, int applicate, int begin, int end)
{
    int[,,] array = new int[rows, columns, applicate];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < applicate ; k++)
            {
                Random arr = new Random();
                int temp = 0;
                temp  = arr.Next(begin, end);
                array[i, j, k] = temp;
            }
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
int applicate = EnterData("Введите количество столбцов по аппликате:  ");
int[,,] matrix = CreateMassive(rows, columns, applicate, 10, 100);
PrintArray(matrix);
Console.WriteLine();