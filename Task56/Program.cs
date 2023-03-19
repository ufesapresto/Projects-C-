// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
//определение строки с наименьшей суммой элемента:
//1. Создание массива, элементами которого являются суммы строк матрицы
int[] SumStringNumbers(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}
//2. Метод поиска номера строки с минимальной суммой элементов
int MinSumElements(int[] array)
{
    int min = array[0];
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (min == array[i]) minPosition = i + 1;
    }
    return minPosition;
}

// тело программы
int[,] array2d = CreateNewMatrix(4, 6, 0, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] arr = SumStringNumbers(array2d);
int min = MinSumElements(arr);
Console.WriteLine($"Номер строки с минимальной суммой элементов -> {min}");
