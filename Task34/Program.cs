// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
//медод поиска количества четных чисел
int QuantityEvenNumbers(int [] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0) count++;
    }
return count;
} 


int[] arr = CreateNewRndInt(10, 100, 999);
PrintArray(arr);
int quantity = QuantityEvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в массиве -> {quantity}");  
