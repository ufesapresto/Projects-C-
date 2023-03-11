// Программа создания lдвумерногго массива, размером m,n
// заполненного случайными числами, с последующей заменой чисел с двумя четными индексами
// на их квадраты

//метод создания двумерного массива
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
//метод вывода массива в консоль
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

//метод замены чисел в массиве на их квадраты
int[,] CangingMatrix(int[,] matrix)
{
    int[,] changedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) 
            {
            changedMatrix[i, j] = matrix[i, j] * matrix[i, j];
            }
            else changedMatrix[i, j] = matrix[i, j];
        }
    }
    return changedMatrix;
}

int[,] array2d = CreateNewMatrix(3, 4, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[,] newArray2d = CangingMatrix(array2d);
PrintMatrix(newArray2d);
