// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:                    В итоге получается вот такой массив:
// 1 4 7 2                                    7 4 2 1  
// 5 9 2 3                                    9 5 3 2
// 8 4 2 4                                    8 4 4 2
int[,] FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortDescending(int[,] matrix)
{
int temp; 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            if (matrix[k, j] < matrix[k, j + 1])
            {
                temp = matrix[k, j + 1];
                matrix[k, j + 1] = matrix[k, j];
                matrix[k, j] = temp;
            }
        }
    }
}
}
try
{
    Console.Write("Введите количество строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = FillMatrix(m, n);
    Console.WriteLine("Исходный массив:");
    PrintMatrix(matrix);
    SortDescending(matrix);
    Console.WriteLine("Отсортированный массив:");
    PrintMatrix(matrix);
}
catch 
{
    Console.WriteLine("Ошибка!");
}