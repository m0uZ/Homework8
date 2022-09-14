// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.
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
int LargestSumElements(int[,] matrix)
{
    int max = 0;
    int index = 0;
    for (int i = 1; i < matrix.GetLength(0) + 1; i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp += matrix[i - 1, j];
        }
        if (temp > max)
        {
            max = temp;
            index = i;
        }

    }
    return max;
}
void SmallestSumElements(int[,] matrix, int max)
{
    int min = max;
    int index = 0;
    for (int i = 1; i < matrix.GetLength(0) + 1; i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp += matrix[i - 1, j];
        }
        if (temp < min)
        {
            min = temp;
            index = i;
        }
    }
    Console.WriteLine($"Строка {index} содежит наименьшую сумму элементов = {min}");
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
    int max = LargestSumElements(matrix);
    Console.WriteLine();
    SmallestSumElements(matrix, max);
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Ошибка!");
}
