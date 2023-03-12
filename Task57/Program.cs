// // Программа, которая считает количество одинаковых элементов массива

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
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        if (i < array.Length - 1) Console.Write("  ");
    }
    Console.WriteLine();
}
// метод преобразования двумерного массива в одномерный
int[] ChangingMatrixToArray(int[,] matrix)
{
    int c = 0;
    int[] arr = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr [c] = matrix[i, j];
            c++;
        }    
    }
    return arr;
}
// метод вывода количества одинаковых чисел
void CountSimilarNumbers(int[] array)
{
    int count = 1;
    int firstNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (firstNumber == array[i]) count++;
        else
        {
            Console.WriteLine($"Число {firstNumber} повторяется {count} раз");
            firstNumber = array[i];
            count = 1;
        }
        }
        Console.WriteLine($"Число {firstNumber} повторяется {count} раз");
}
// тело программы
int[,] array2d = CreateNewMatrix(4, 4, 0, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = ChangingMatrixToArray(array2d);
PrintArray(array);
Array.Sort(array);
PrintArray(array);
CountSimilarNumbers(array);
