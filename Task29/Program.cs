// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = newArray(num, 0, 100);
Console.Write($"Полученный массив чисел -> ");
printArray(arr);

int[] newArray(int num, int min, int max) 
{
    int[] array = new int[num];
    Random rand = new Random();

    for (int i = 0; i < num; i++)
    {
         array[i] = rand.Next(min,max);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)Console.Write(",");
    }
    Console.WriteLine("]");
}    