// Задача 31: Напишите программу, которая задаёт массив из 12 элементов
// из промежутка от -9 до 9 и выводит на экран сумму положительных и отрицательных чисел.
//метод создания массива
int[] CreateNewRndInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
//метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length - 1)Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
} 
//метод создания массива с 2 элементами - суммой положительных и отрицательных чисел массива
int[] SumPositiveNegativeNum(int[] array)
{
    int sumPositiveNum = 0;
    int sumNegativeNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNegativeNum += array[i];
        else sumPositiveNum += array[i];
    }
    return new int[]{sumPositiveNum, sumNegativeNum};
}
//вывод результатов в консоль
int[] arr = CreateNewRndInt(12, -9, 9);
PrintArray(arr);
int [] sumPositiveNegativeNum = SumPositiveNegativeNum(arr);
Console.WriteLine($"Сумма положительных чисел равна {sumPositiveNegativeNum[0]}");
Console.WriteLine($"Сумма отрицательных чисел равна {sumPositiveNegativeNum[1]}");

