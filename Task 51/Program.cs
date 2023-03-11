// Программа создания двумерногго массива, размером m,n
// заполненного случайными числами, с последующим вычислением суммы чисел
// главной диагоннали (индексы (0,0), (1,1) и тд)

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
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}"); ;
        }
        Console.WriteLine(" ");
    }
}

// расчет суммы
int SummIndex(int[,] matrix)
{
    int summ = 0;
    int size = matrix.GetLength(0);
    if (size > matrix.GetLength(1)) size = matrix.GetLength(1); 
    for (int i = 0; i < size; i++)
    {
     summ += matrix[i,i];
        }
    return summ;
}

int[,] array2d = CreateNewMatrix(3, 4, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
int result = SummIndex(array2d);
Console.WriteLine($"Сумма необходимых чисел -> {result}");

