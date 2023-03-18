// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
//метод сортировки данных в строках
void SortRowsFromMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                int maxNumber = matrix[i, c];
                if (maxNumber < matrix[i, j])
                {
                    maxNumber = matrix[i, j];
                    int temporary = matrix[i, c];
                    matrix[i, c] = matrix[i, j];
                    matrix[i, j] = temporary;
                }
            }
        }
    }
}


// тело программы
int[,] array2d = CreateNewMatrix(4, 6, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
SortRowsFromMaxToMin(array2d);
PrintMatrix(array2d);