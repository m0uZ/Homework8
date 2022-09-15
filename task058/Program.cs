// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:                     Результирующая матрица будет:
// 2 4 | 3 4                                     18 20
// 3 2 | 3 3                                     15 18
int[,] FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}
try
{
    Console.Write("Введите количество строк матрицы А: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы А: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк матрицы В: \t");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы В: \t");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] matrixA = FillMatrix(m, n);
    int[,] matrixB = FillMatrix(row, col);
    Console.WriteLine("Матрица А: ");
    PrintMatrix(matrixA);
    Console.WriteLine("Матрица В: ");
    PrintMatrix(matrixB);
    int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
    Console.WriteLine("Произведение матриц (Матрица С): ");
    PrintMatrix(matrixC);
}
catch 
{
    Console.WriteLine("Ошибка!");
}

