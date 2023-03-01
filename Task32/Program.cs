//// Задача 32: Напишите программу замены элементов массива
// которая заменяет положительные элементы на соответствующие отрицательные, и наоборот

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
// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)Console.Write(",");
    }
    Console.WriteLine("]");
} 
//медод инверсии
void CangedArray(int [] array)
{
for (int i = 0; i < array.Length; i++)
    {
    array[i] = array [i] * -1;
    }
} 
int[] arr = CreateNewRndInt(12, -100, 100);
PrintArray(arr);
Console.WriteLine();
CangedArray(arr);
PrintArray(arr);