// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет

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

//метод ввода данных пользователем
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] array2d = CreateNewMatrix(3, 4, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();

int rowPosition = Printline("Введите номер строки");
int columnPosition = Printline("Введите номер столбца");

// определение числа
if (rowPosition >= 0 && rowPosition < array2d.GetLength(0) &&
    columnPosition >= 0 && columnPosition < array2d.GetLength(1))
{
    int result = array2d[rowPosition, columnPosition];
    Console.WriteLine($"Ответ - > {result}");
}
else Console.WriteLine("Такого элемента в массиве нет");

