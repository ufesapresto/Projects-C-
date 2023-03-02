//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//метод создания массива
double[] CreateNewRndIntDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

// метод вывода массива округленных чисел в консоль
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 1)}");
        if (i < array.Length - 1) Console.Write(",  ");
    }
    Console.WriteLine("]");
}
// метод поиска максимального числа
double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        {
        if (max < array[i]) max = array[i];
        }
    return max;
}

// метод поиска минимального числа
double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
        if (min > array[i]) min = array[i];
        }
    return min;
}
double[] newArray = CreateNewRndIntDouble(5, -99, 99);
PrintArray(newArray);
double number = MaxNumber(newArray) - MinNumber(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {Math.Round(number, 1)}");