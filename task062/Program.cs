// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];
int i = 0;
int j = 0;

for (int temp = 1; temp <= array.GetLength(0) * array.GetLength(1); temp++)
{
    array[i, j] = temp;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
    else if (i < j && i + j >= array.GetLength(0) - 1) i++;
    else if (i >= j && i + j > array.GetLength(1) - 1) j--;
    else i--;
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
PrintMatrix(array);