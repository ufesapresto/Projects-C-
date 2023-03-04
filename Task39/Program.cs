// Задача 39: Напишите программу, которая разворачивает массив из 12 элементов

//метод создания массива
int[] CreateNewRndInt(int size, int min, int max)
{
    int[] array = new int[size];
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
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

// метод разворота массива

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] arr = CreateNewRndInt(9, 0, 9);
PrintArray(arr);
Console.Write(" -> ");
ReverseArray(arr);
PrintArray(arr);
Console.WriteLine();