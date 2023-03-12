// Программа, которая задает двумерный массив 
// и меняет местами значения в первой и последней строке
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

// метод замены значений в строках
void ChangingMatrix(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRow,j];
        matrix[firstRow,j] = matrix[lastRow,j];
        matrix[lastRow,j] = temp;
    }
}
int[,] array2d = CreateNewMatrix(3, 5, -99, 99);
PrintMatrix(array2d);
Console.WriteLine();
ChangingMatrix(array2d);
PrintMatrix(array2d);
