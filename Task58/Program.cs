// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] CreateNewMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}"); ;
        }
        Console.WriteLine("]");
    }
}
//метод перомножения матриц
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    multMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return multMatrix;
}
//тело программы
int[,] array2d = CreateNewMatrix(2, 2, 0, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[,] matrix2d = CreateNewMatrix(2, 2, 0, 9);
PrintMatrix(matrix2d);
Console.WriteLine();
if (array2d.GetLength(0) == matrix2d.GetLength(1))
{
    Console.WriteLine("Произведение матриц");
    int[,] resultMatrix = MultiplicationMatrix(array2d, matrix2d);
    PrintMatrix(resultMatrix);
}
else Console.WriteLine("Перемножить данные матрицы невозможно");
