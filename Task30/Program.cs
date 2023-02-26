Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = newArray(num);
Console.WriteLine($"Полученный массив из {num} элементов");
printArray(arr);

int[] newArray(int num) 
{
    int[] array = new int[num];
    Random ran = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = ran.Next(0,2);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
